﻿using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace HttpBin.Utils
{
    static public class Unpack
    {
        static public Dictionary<string, string> convertToDict(IQueryCollection queryString)
        {
            var newDict = new Dictionary<string, string>();
            foreach (var entry in queryString)
            {
                newDict.Add(entry.Key, entry.Value);
            }
            return newDict;
        }

        static public Dictionary<string, string> convertToDict(IHeaderDictionary headerDict, bool showEnv = false)
        {
            var newDict = new Dictionary<string, string>();
            foreach (var entry in headerDict)
            {
                if (entry.Key.StartsWith("X") && showEnv == false)
                {
                    break;
                }

                else
                {
                    newDict.Add(entry.Key, entry.Value);
                }

            }
            return newDict;
        }

        static public Dictionary<string, string> convertToDict(IFormCollection headerDict)
        {
            var newDict = new Dictionary<string, string>();
            foreach (var entry in headerDict)
            {
                newDict.Add(entry.Key, entry.Value);
            }
            return newDict;
        }

        static public Dictionary<string, string> convertToDict(IRequestCookieCollection cookies)
        {
            var newDict = new Dictionary<string, string>();
            foreach (var entry in cookies)
            {
                newDict.Add(entry.Key, entry.Value);
            }
            return newDict;
        }
    }
}
