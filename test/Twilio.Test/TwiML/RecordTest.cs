/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NUnit.Framework;
using System;
using Twilio.Converters;
using Twilio.TwiML.Voice;

namespace Twilio.Tests.TwiML 
{

    [TestFixture]
    public class RecordTest : TwilioTest 
    {
        [Test]
        public void TestEmptyElement()
        {
            var elem = new Record();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Record></Record>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithParams()
        {
            var elem = new Record(
                new Uri("https://example.com"),
                Twilio.Http.HttpMethod.Get,
                1,
                "finish_on_key",
                1,
                true,
                Record.TrimEnum.TrimSilence,
                new Uri("https://example.com"),
                Twilio.Http.HttpMethod.Get,
                true,
                new Uri("https://example.com")
            );
            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Record action=\"https://example.com\" method=\"GET\" timeout=\"1\" finishOnKey=\"finish_on_key\" maxLength=\"1\" playBeep=\"true\" trim=\"trim-silence\" recordingStatusCallback=\"https://example.com\" recordingStatusCallbackMethod=\"GET\" transcribe=\"true\" transcribeCallback=\"https://example.com\"></Record>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Record();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Record newParam1=\"value\" newParam2=\"1\"></Record>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithTextNode()
        {
            var elem = new Record();

            elem.AddText("Here is the content");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Record>Here is the content</Record>",
                elem.ToString()
            );
        }

        [Test]
        public void TestAllowGenericChildNodes()
        {
            var elem = new Record();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Record>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</Record>",
                elem.ToString()
            );
        }

        [Test]
        public void TestMixedContent()
        {
            var elem = new Record();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Record>before<Child>content</Child>after</Record>",
                elem.ToString()
            );
        }
    }

}