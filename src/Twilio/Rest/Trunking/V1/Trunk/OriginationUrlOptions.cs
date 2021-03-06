/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Trunking.V1.Trunk 
{

    /// <summary>
    /// FetchOriginationUrlOptions
    /// </summary>
    public class FetchOriginationUrlOptions : IOptions<OriginationUrlResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchOriginationUrlOptions
        /// </summary>
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchOriginationUrlOptions(string pathTrunkSid, string pathSid)
        {
            PathTrunkSid = pathTrunkSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// DeleteOriginationUrlOptions
    /// </summary>
    public class DeleteOriginationUrlOptions : IOptions<OriginationUrlResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteOriginationUrlOptions
        /// </summary>
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteOriginationUrlOptions(string pathTrunkSid, string pathSid)
        {
            PathTrunkSid = pathTrunkSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// CreateOriginationUrlOptions
    /// </summary>
    public class CreateOriginationUrlOptions : IOptions<OriginationUrlResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }
        /// <summary>
        /// Weight is used to determine the share of load when more than one URI has the same priority.
        /// </summary>
        public int? Weight { get; }
        /// <summary>
        /// Priority ranks the importance of the URI.
        /// </summary>
        public int? Priority { get; }
        /// <summary>
        /// A boolean value indicating whether the URL is enabled or disabled.
        /// </summary>
        public bool? Enabled { get; }
        /// <summary>
        /// A human readable descriptive text, up to 64 characters long.
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The SIP address you want Twilio to route your Origination calls to.
        /// </summary>
        public Uri SipUrl { get; }

        /// <summary>
        /// Construct a new CreateOriginationUrlOptions
        /// </summary>
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="weight"> Weight is used to determine the share of load when more than one URI has the same priority.
        ///              </param>
        /// <param name="priority"> Priority ranks the importance of the URI. </param>
        /// <param name="enabled"> A boolean value indicating whether the URL is enabled or disabled. </param>
        /// <param name="friendlyName"> A human readable descriptive text, up to 64 characters long. </param>
        /// <param name="sipUrl"> The SIP address you want Twilio to route your Origination calls to. </param>
        public CreateOriginationUrlOptions(string pathTrunkSid, 
                                           int? weight, 
                                           int? priority, 
                                           bool? enabled, 
                                           string friendlyName, 
                                           Uri sipUrl)
        {
            PathTrunkSid = pathTrunkSid;
            Weight = weight;
            Priority = priority;
            Enabled = enabled;
            FriendlyName = friendlyName;
            SipUrl = sipUrl;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Weight != null)
            {
                p.Add(new KeyValuePair<string, string>("Weight", Weight.ToString()));
            }

            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.ToString()));
            }

            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString().ToLower()));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (SipUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SipUrl", Serializers.Url(SipUrl)));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadOriginationUrlOptions
    /// </summary>
    public class ReadOriginationUrlOptions : ReadOptions<OriginationUrlResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }

        /// <summary>
        /// Construct a new ReadOriginationUrlOptions
        /// </summary>
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        public ReadOriginationUrlOptions(string pathTrunkSid)
        {
            PathTrunkSid = pathTrunkSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// UpdateOriginationUrlOptions
    /// </summary>
    public class UpdateOriginationUrlOptions : IOptions<OriginationUrlResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// Weight is used to determine the share of load when more than one URI has the same priority.
        /// </summary>
        public int? Weight { get; set; }
        /// <summary>
        /// Priority ranks the importance of the URI.
        /// </summary>
        public int? Priority { get; set; }
        /// <summary>
        /// A boolean value indicating whether the URL is enabled or disabled.
        /// </summary>
        public bool? Enabled { get; set; }
        /// <summary>
        /// A human readable descriptive text, up to 64 characters long.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The SIP address you want Twilio to route your Origination calls to.
        /// </summary>
        public Uri SipUrl { get; set; }

        /// <summary>
        /// Construct a new UpdateOriginationUrlOptions
        /// </summary>
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateOriginationUrlOptions(string pathTrunkSid, string pathSid)
        {
            PathTrunkSid = pathTrunkSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Weight != null)
            {
                p.Add(new KeyValuePair<string, string>("Weight", Weight.ToString()));
            }

            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.ToString()));
            }

            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString().ToLower()));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (SipUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SipUrl", Serializers.Url(SipUrl)));
            }

            return p;
        }
    }

}