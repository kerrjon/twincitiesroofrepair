﻿using System;
using System.Web.WebPages;

namespace TwinCitiesRoofRepair
{
  public class DisplayModeConfig
  {
    public static void RegisterModes(DisplayModeProvider provider)
    {
      provider.Modes.Insert(0, new DefaultDisplayMode("Phone")
      {
        ContextCondition = (
          context => (
            (context.GetOverriddenUserAgent() != null) && (
              (context.GetOverriddenUserAgent().IndexOf("iPhone",
                  StringComparison.OrdinalIgnoreCase) >= 0) ||
              (context.GetOverriddenUserAgent().IndexOf("iPod",
                  StringComparison.OrdinalIgnoreCase) >= 0) ||
              (context.GetOverriddenUserAgent().IndexOf("Droid",
                  StringComparison.OrdinalIgnoreCase) >= 0) ||
              (context.GetOverriddenUserAgent().IndexOf("Blackberry",
                  StringComparison.OrdinalIgnoreCase) >= 0) ||
              (context.GetOverriddenUserAgent().IndexOf("Windows Phone",
                  StringComparison.OrdinalIgnoreCase) >= 0) ||
              (context.GetOverriddenUserAgent().StartsWith("Blackberry",
                  StringComparison.OrdinalIgnoreCase))
            )
          )
        )
      }
    );
    }
  }
}
