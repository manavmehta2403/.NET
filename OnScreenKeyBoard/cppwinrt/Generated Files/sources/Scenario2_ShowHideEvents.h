#pragma once
#include "Scenario2_ShowHideEvents.g.h"

// Note: Remove this static_assert after copying these generated source files to your project.
// This assertion exists to avoid compiling these generated source files directly.
static_assert(false, "Do not compile generated C++/WinRT source files directly");

namespace winrt::SDKTemplate::implementation
{
    struct Scenario2_ShowHideEvents : Scenario2_ShowHideEventsT<Scenario2_ShowHideEvents>
    {
        Scenario2_ShowHideEvents() = default;

    };
}
namespace winrt::SDKTemplate::factory_implementation
{
    struct Scenario2_ShowHideEvents : Scenario2_ShowHideEventsT<Scenario2_ShowHideEvents, implementation::Scenario2_ShowHideEvents>
    {
    };
}
