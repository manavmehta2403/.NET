#pragma once
#include "CustomTextBox.g.h"

// Note: Remove this static_assert after copying these generated source files to your project.
// This assertion exists to avoid compiling these generated source files directly.
static_assert(false, "Do not compile generated C++/WinRT source files directly");

namespace winrt::SDKTemplate::implementation
{
    struct CustomTextBox : CustomTextBoxT<CustomTextBox>
    {
        CustomTextBox() = default;

    };
}
namespace winrt::SDKTemplate::factory_implementation
{
    struct CustomTextBox : CustomTextBoxT<CustomTextBox, implementation::CustomTextBox>
    {
    };
}
