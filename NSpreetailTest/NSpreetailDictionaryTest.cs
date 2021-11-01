using NUnit.Framework;
using System;
using System.IO;
using SpreetailConsole;

namespace NSpreetailTest
{
    public class NSpreetailDictionaryTest
    {
        [Test]
        public void Keys()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var dic = new SpreetailDictionary<string, string>();
                dic.AddKeyValue("foo", "bar");
                dic.AddKeyValue("baz", "bang");
                dic.GetKeys();

                string expected = string.Format("Added{0}Added{0}1)foo{0}2)baz{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void Members()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var dic = new SpreetailDictionary<string, string>();
                dic.AddKeyValue("foo", "bar");
                dic.AddKeyValue("foo", "baz");
                dic.GetMemebers("foo");
                dic.GetMemebers("bar");

                string expected = string.Format("Added{0}Added{0}1)bar{0}2)baz{0}ERROR, key does not exist.{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }


        [Test]
        public void Add()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                var dic = new SpreetailDictionary<string, string>();
                dic.AddKeyValue("foo", "bar");
                dic.AddKeyValue("foo", "baz");
                dic.AddKeyValue("foo", "bar");
                string expected = string.Format("Added{0}Added{0}ERROR, member already exists for key{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void Remove()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var dic = new SpreetailDictionary<string, string>();
                dic.AddKeyValue("foo", "bar");
                dic.AddKeyValue("foo", "baz");
                dic.RemoveKeyValue("foo", "bar");
                dic.RemoveKeyValue("foo", "bar");
                dic.GetKeys();
                dic.RemoveKeyValue("foo", "baz");
                dic.GetKeys();
                dic.RemoveKeyValue("boom", "pow");

                string expected = string.Format("Added{0}Added{0}Removed{0}ERROR, member does not exist{0}1)foo{0}Removed{0}(empty set){0}ERROR, key does not exist{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void RemoveAll()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var dic = new SpreetailDictionary<string, string>();
                dic.AddKeyValue("foo", "bar");
                dic.AddKeyValue("foo", "baz");
                dic.GetKeys();
                dic.RemoveAllMemebers("foo");
                dic.GetKeys();
                dic.RemoveAllMemebers("foo");

                string expected = string.Format("Added{0}Added{0}1)foo{0}Removed{0}(empty set){0}ERROR, key does not exist{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }


        }

        [Test]
        public void Clear()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var dic = new SpreetailDictionary<string, string>();
                dic.AddKeyValue("foo", "bar");
                dic.AddKeyValue("bang", "zip");
                dic.GetKeys();
                dic.ClearAllItems();
                dic.GetKeys();
                dic.ClearAllItems();
                dic.GetKeys();

                string expected = string.Format("Added{0}Added{0}1)foo{0}2)bang{0}) Cleared{0}(empty set){0}) Cleared{0}(empty set){0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void KeyExists()
        {


            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var dic = new SpreetailDictionary<string, string>();
                dic.KeyExists("foo");
                dic.AddKeyValue("foo", "bar");
                dic.KeyExists("foo");

                string expected = string.Format("False{0}Added{0}True{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void MemberExists()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var dic = new SpreetailDictionary<string, string>();
                dic.MemeberExists("foo", "bar");
                dic.AddKeyValue("foo", "bar");
                dic.MemeberExists("foo", "bar");
                dic.MemeberExists("foo", "baz");

                string expected = string.Format("False{0}Added{0}True{0}False{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [Test]
        public void AllMemebers()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var dic = new SpreetailDictionary<string, string>();
                dic.AllMemebers();
                dic.AddKeyValue("foo", "bar");
                dic.AddKeyValue("foo", "baz");
                dic.AllMemebers();
                dic.AddKeyValue("bang", "bar");
                dic.AddKeyValue("bang", "baz");
                dic.AllMemebers();

                string expected = string.Format("(empty set){0}Added{0}Added{0}1)bar{0}2)baz{0}Added{0}Added{0}1)bar{0}2)baz{0}3)bar{0}4)baz{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }


        }

        [Test]
        public void Items()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var dic = new SpreetailDictionary<string, string>();
                dic.Items();
                dic.AddKeyValue("foo", "bar");
                dic.AddKeyValue("foo", "baz");
                dic.Items();
                dic.AddKeyValue("bang", "bar");
                dic.AddKeyValue("bang", "baz");
                dic.Items();

                string expected = string.Format("(empty set){0}Added{0}Added{0}1)foo:bar{0}2)foo:baz{0}Added{0}Added{0}1)foo:bar{0}2)foo:baz{0}3)bang:bar{0}4)bang:baz{0}", Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }
    }
}