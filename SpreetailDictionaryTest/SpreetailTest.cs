using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using SpreetailConsole;

namespace SpreetailTest
{
    [TestClass]
    public class SpreetailDictionaryTest
    {
        [TestMethod]
        public void Keys()
        {
            var dic = new SpreetailDictionary<string, string>();
            dic.AddKeyValue("foo", "bar");
            dic.AddKeyValue("baz", "bang");
            dic.GetKeys();
        }

        [TestMethod]
        public void Memebers()
        {
            var dic = new SpreetailDictionary<string, string>();
            dic.AddKeyValue("foo", "bar");
            dic.AddKeyValue("foo", "baz");
            dic.GetMemebers("foo");
            dic.GetMemebers("bar");

        }

        [TestMethod]
        public void Add()
        {
            var dic = new SpreetailDictionary<string, string>();
            dic.AddKeyValue("foo", "bar");
            dic.AddKeyValue("foo", "baz");
            dic.AddKeyValue("foo", "bar");
        }

        [TestMethod]
        public void Remove()
        {
            var dic = new SpreetailDictionary<string, string>();
            dic.AddKeyValue("foo", "bar");
            dic.AddKeyValue("foo", "baz");
            dic.RemoveKeyValue("foo", "bar");
            dic.RemoveKeyValue("foo", "bar");
            dic.GetKeys();
            dic.RemoveKeyValue("foo", "baz");
            dic.GetKeys();
            dic.RemoveKeyValue("boom", "pow");
        }

        [TestMethod]
        public void RemoveAll()
        {
            var dic = new SpreetailDictionary<string, string>();
            dic.AddKeyValue("foo", "bar");
            dic.AddKeyValue("foo", "baz");
            dic.GetKeys();
            dic.RemoveAllMemebers("foo");
            dic.GetKeys();
            dic.RemoveAllMemebers("foo");
        }

        [TestMethod]
        public void Clear()
        {
            var dic = new SpreetailDictionary<string, string>();
            dic.AddKeyValue("foo", "bar");
            dic.AddKeyValue("bang", "zip");
            dic.GetKeys();
            dic.ClearAllItems();
            dic.GetKeys();
            dic.ClearAllItems();
            dic.GetKeys();
        }

        [TestMethod]
        public void KeyExists()
        {
            var dic = new SpreetailDictionary<string, string>();
            dic.KeyExists("foo");
            dic.AddKeyValue("foo", "bar");
            dic.KeyExists("foo");
        }

        [TestMethod]
        public void MemberExists()
        {
            var dic = new SpreetailDictionary<string, string>();
            dic.MemeberExists("foo", "bar");
            dic.AddKeyValue("foo", "bar");
            dic.MemeberExists("foo", "bar");
            dic.MemeberExists("foo", "baz");
        }

        [TestMethod]
        public void AllMemebers()
        {
            var dic = new SpreetailDictionary<string, string>();
            dic.AllMemebers();
            dic.AddKeyValue("foo", "bar");
            dic.AddKeyValue("foo", "baz");
            dic.AllMemebers();
            dic.AddKeyValue("bang", "bar");
            dic.AddKeyValue("bang", "baz");
            dic.AllMemebers();
        }

        [TestMethod]
        public void Items()
        {
            var dic = new SpreetailDictionary<string, string>();
            dic.Items();
            dic.AddKeyValue("foo", "bar");
            dic.AddKeyValue("foo", "baz");
            dic.Items();
            dic.AddKeyValue("bang", "bar");
            dic.AddKeyValue("bang", "baz");
            dic.Items();
        }
    }
}
