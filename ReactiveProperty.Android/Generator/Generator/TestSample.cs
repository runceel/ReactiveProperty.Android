using System;
using System.Linq;
using NUnit.Framework;
using System.Reflection;
using Android.Views;
using Android.OS;
using Android.Util;
using System.Text;
using System.IO;


namespace Generator
{
    [TestFixture]
    public class TestsSample
    {

        [SetUp]
        public void Setup() { }


        [TearDown]
        public void Tear() { }

        [Test]
        public void Generate()
        {
            var views = Assembly.GetAssembly(typeof(View)).GetTypes()
                .Where(x => typeof(View).GetTypeInfo().IsAssignableFrom(x));
            var sb = new StringBuilder();
            foreach (var view in views)
            {
                if (!view.IsPublic) { continue; }
                var typeName = view.FullName;
                foreach (var evt in view.GetEvents())
                {
                    var eventName = evt.Name;
                    var eventArgsType = evt.EventHandlerType.GetTypeInfo().GetGenericArguments().FirstOrDefault();
                    if (eventArgsType == null)
                    {
                        sb.AppendLine("public static IObservable<EventArgs> " + eventName + "AsObservable(this " + typeName + " self)");
                        sb.AppendLine("{");
                        sb.AppendLine("    return Observable.FromEvent<EventHandler, EventArgs>(");
                        sb.AppendLine("        h => (s, e) => h(e),");
                        sb.AppendLine("        h => self." + eventName + " += h,");
                        sb.AppendLine("        h => self." + eventName + " -= h);");
                        sb.AppendLine("}");
                    }
                    else
                    {
                        var eventArgsName = eventArgsType.FullName.Replace('+', '.');
                        sb.AppendLine("public static IObservable<" + eventArgsName + "> " + eventName + "AsObservable(this " + typeName + " self)");
                        sb.AppendLine("{");
                        sb.AppendLine("    return Observable.FromEvent<EventHandler<" + eventArgsName + ">, " + eventArgsName + ">(");
                        sb.AppendLine("        h => (s, e) => h(e),");
                        sb.AppendLine("        h => self." + eventName + " += h,");
                        sb.AppendLine("        h => self." + eventName + " -= h);");
                        sb.AppendLine("}");
                    }
                }
            }
            var f = Path.Combine(Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDownloads).AbsolutePath, "Generated.cs");
            Log.Info("path", f);
            using (var sw = new StreamWriter(f))
            {
                sw.WriteLine(sb.ToString());
            }
        }
    }
}