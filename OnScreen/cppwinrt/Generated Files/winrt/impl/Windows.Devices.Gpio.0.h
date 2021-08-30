// WARNING: Please don't edit this file. It was generated by C++/WinRT v2.0.200615.7

#ifndef WINRT_Windows_Devices_Gpio_0_H
#define WINRT_Windows_Devices_Gpio_0_H
WINRT_EXPORT namespace winrt::Windows::Devices::Gpio::Provider
{
    struct IGpioProvider;
}
WINRT_EXPORT namespace winrt::Windows::Foundation
{
    struct EventRegistrationToken;
    struct IAsyncAction;
    template <typename TResult> struct __declspec(empty_bases) IAsyncOperation;
    template <typename TSender, typename TResult> struct __declspec(empty_bases) TypedEventHandler;
}
WINRT_EXPORT namespace winrt::Windows::Foundation::Collections
{
    template <typename T> struct __declspec(empty_bases) IVectorView;
    template <typename T> struct __declspec(empty_bases) IVector;
}
WINRT_EXPORT namespace winrt::Windows::Devices::Gpio
{
    enum class GpioChangePolarity : int32_t
    {
        Falling = 0,
        Rising = 1,
        Both = 2,
    };
    enum class GpioOpenStatus : int32_t
    {
        PinOpened = 0,
        PinUnavailable = 1,
        SharingViolation = 2,
        MuxingConflict = 3,
        UnknownError = 4,
    };
    enum class GpioPinDriveMode : int32_t
    {
        Input = 0,
        Output = 1,
        InputPullUp = 2,
        InputPullDown = 3,
        OutputOpenDrain = 4,
        OutputOpenDrainPullUp = 5,
        OutputOpenSource = 6,
        OutputOpenSourcePullDown = 7,
    };
    enum class GpioPinEdge : int32_t
    {
        FallingEdge = 0,
        RisingEdge = 1,
    };
    enum class GpioPinValue : int32_t
    {
        Low = 0,
        High = 1,
    };
    enum class GpioSharingMode : int32_t
    {
        Exclusive = 0,
        SharedReadOnly = 1,
    };
    struct IGpioChangeCounter;
    struct IGpioChangeCounterFactory;
    struct IGpioChangeReader;
    struct IGpioChangeReaderFactory;
    struct IGpioController;
    struct IGpioControllerStatics;
    struct IGpioControllerStatics2;
    struct IGpioPin;
    struct IGpioPinValueChangedEventArgs;
    struct GpioChangeCounter;
    struct GpioChangeReader;
    struct GpioController;
    struct GpioPin;
    struct GpioPinValueChangedEventArgs;
    struct GpioChangeCount;
    struct GpioChangeRecord;
}
namespace winrt::impl
{
    template <> struct category<Windows::Devices::Gpio::IGpioChangeCounter>{ using type = interface_category; };
    template <> struct category<Windows::Devices::Gpio::IGpioChangeCounterFactory>{ using type = interface_category; };
    template <> struct category<Windows::Devices::Gpio::IGpioChangeReader>{ using type = interface_category; };
    template <> struct category<Windows::Devices::Gpio::IGpioChangeReaderFactory>{ using type = interface_category; };
    template <> struct category<Windows::Devices::Gpio::IGpioController>{ using type = interface_category; };
    template <> struct category<Windows::Devices::Gpio::IGpioControllerStatics>{ using type = interface_category; };
    template <> struct category<Windows::Devices::Gpio::IGpioControllerStatics2>{ using type = interface_category; };
    template <> struct category<Windows::Devices::Gpio::IGpioPin>{ using type = interface_category; };
    template <> struct category<Windows::Devices::Gpio::IGpioPinValueChangedEventArgs>{ using type = interface_category; };
    template <> struct category<Windows::Devices::Gpio::GpioChangeCounter>{ using type = class_category; };
    template <> struct category<Windows::Devices::Gpio::GpioChangeReader>{ using type = class_category; };
    template <> struct category<Windows::Devices::Gpio::GpioController>{ using type = class_category; };
    template <> struct category<Windows::Devices::Gpio::GpioPin>{ using type = class_category; };
    template <> struct category<Windows::Devices::Gpio::GpioPinValueChangedEventArgs>{ using type = class_category; };
    template <> struct category<Windows::Devices::Gpio::GpioChangePolarity>{ using type = enum_category; };
    template <> struct category<Windows::Devices::Gpio::GpioOpenStatus>{ using type = enum_category; };
    template <> struct category<Windows::Devices::Gpio::GpioPinDriveMode>{ using type = enum_category; };
    template <> struct category<Windows::Devices::Gpio::GpioPinEdge>{ using type = enum_category; };
    template <> struct category<Windows::Devices::Gpio::GpioPinValue>{ using type = enum_category; };
    template <> struct category<Windows::Devices::Gpio::GpioSharingMode>{ using type = enum_category; };
    template <> struct category<Windows::Devices::Gpio::GpioChangeCount>{ using type = struct_category<uint64_t, Windows::Foundation::TimeSpan>; };
    template <> struct category<Windows::Devices::Gpio::GpioChangeRecord>{ using type = struct_category<Windows::Foundation::TimeSpan, Windows::Devices::Gpio::GpioPinEdge>; };
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::GpioChangeCounter> = L"Windows.Devices.Gpio.GpioChangeCounter";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::GpioChangeReader> = L"Windows.Devices.Gpio.GpioChangeReader";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::GpioController> = L"Windows.Devices.Gpio.GpioController";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::GpioPin> = L"Windows.Devices.Gpio.GpioPin";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::GpioPinValueChangedEventArgs> = L"Windows.Devices.Gpio.GpioPinValueChangedEventArgs";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::GpioChangePolarity> = L"Windows.Devices.Gpio.GpioChangePolarity";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::GpioOpenStatus> = L"Windows.Devices.Gpio.GpioOpenStatus";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::GpioPinDriveMode> = L"Windows.Devices.Gpio.GpioPinDriveMode";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::GpioPinEdge> = L"Windows.Devices.Gpio.GpioPinEdge";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::GpioPinValue> = L"Windows.Devices.Gpio.GpioPinValue";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::GpioSharingMode> = L"Windows.Devices.Gpio.GpioSharingMode";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::GpioChangeCount> = L"Windows.Devices.Gpio.GpioChangeCount";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::GpioChangeRecord> = L"Windows.Devices.Gpio.GpioChangeRecord";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::IGpioChangeCounter> = L"Windows.Devices.Gpio.IGpioChangeCounter";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::IGpioChangeCounterFactory> = L"Windows.Devices.Gpio.IGpioChangeCounterFactory";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::IGpioChangeReader> = L"Windows.Devices.Gpio.IGpioChangeReader";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::IGpioChangeReaderFactory> = L"Windows.Devices.Gpio.IGpioChangeReaderFactory";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::IGpioController> = L"Windows.Devices.Gpio.IGpioController";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::IGpioControllerStatics> = L"Windows.Devices.Gpio.IGpioControllerStatics";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::IGpioControllerStatics2> = L"Windows.Devices.Gpio.IGpioControllerStatics2";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::IGpioPin> = L"Windows.Devices.Gpio.IGpioPin";
    template <> inline constexpr auto& name_v<Windows::Devices::Gpio::IGpioPinValueChangedEventArgs> = L"Windows.Devices.Gpio.IGpioPinValueChangedEventArgs";
    template <> inline constexpr guid guid_v<Windows::Devices::Gpio::IGpioChangeCounter>{ 0xCB5EC0DE,0x6801,0x43FF,{ 0x80,0x3D,0x45,0x76,0x62,0x8A,0x8B,0x26 } }; // CB5EC0DE-6801-43FF-803D-4576628A8B26
    template <> inline constexpr guid guid_v<Windows::Devices::Gpio::IGpioChangeCounterFactory>{ 0x147D94B6,0x0A9E,0x410C,{ 0xB4,0xFA,0xF8,0x9F,0x40,0x52,0x08,0x4D } }; // 147D94B6-0A9E-410C-B4FA-F89F4052084D
    template <> inline constexpr guid guid_v<Windows::Devices::Gpio::IGpioChangeReader>{ 0x0ABC885F,0xE031,0x48E8,{ 0x85,0x90,0x70,0xDE,0x78,0x36,0x3C,0x6D } }; // 0ABC885F-E031-48E8-8590-70DE78363C6D
    template <> inline constexpr guid guid_v<Windows::Devices::Gpio::IGpioChangeReaderFactory>{ 0xA9598EF3,0x390E,0x441A,{ 0x9D,0x1C,0xE8,0xDE,0x0B,0x2D,0xF0,0xDF } }; // A9598EF3-390E-441A-9D1C-E8DE0B2DF0DF
    template <> inline constexpr guid guid_v<Windows::Devices::Gpio::IGpioController>{ 0x284012E3,0x7461,0x469C,{ 0xA8,0xBC,0x61,0xD6,0x9D,0x08,0xA5,0x3C } }; // 284012E3-7461-469C-A8BC-61D69D08A53C
    template <> inline constexpr guid guid_v<Windows::Devices::Gpio::IGpioControllerStatics>{ 0x2ED6F42E,0x7AF7,0x4116,{ 0x95,0x33,0xC4,0x3D,0x99,0xA1,0xFB,0x64 } }; // 2ED6F42E-7AF7-4116-9533-C43D99A1FB64
    template <> inline constexpr guid guid_v<Windows::Devices::Gpio::IGpioControllerStatics2>{ 0x912B7D20,0x6CA4,0x4106,{ 0xA3,0x73,0xFF,0xFD,0x34,0x6B,0x0E,0x5B } }; // 912B7D20-6CA4-4106-A373-FFFD346B0E5B
    template <> inline constexpr guid guid_v<Windows::Devices::Gpio::IGpioPin>{ 0x11D9B087,0xAFAE,0x4790,{ 0x9E,0xE9,0xE0,0xEA,0xC9,0x42,0xD2,0x01 } }; // 11D9B087-AFAE-4790-9EE9-E0EAC942D201
    template <> inline constexpr guid guid_v<Windows::Devices::Gpio::IGpioPinValueChangedEventArgs>{ 0x3137AAE1,0x703D,0x4059,{ 0xBD,0x24,0xB5,0xB2,0x5D,0xFF,0xB8,0x4E } }; // 3137AAE1-703D-4059-BD24-B5B25DFFB84E
    template <> struct default_interface<Windows::Devices::Gpio::GpioChangeCounter>{ using type = Windows::Devices::Gpio::IGpioChangeCounter; };
    template <> struct default_interface<Windows::Devices::Gpio::GpioChangeReader>{ using type = Windows::Devices::Gpio::IGpioChangeReader; };
    template <> struct default_interface<Windows::Devices::Gpio::GpioController>{ using type = Windows::Devices::Gpio::IGpioController; };
    template <> struct default_interface<Windows::Devices::Gpio::GpioPin>{ using type = Windows::Devices::Gpio::IGpioPin; };
    template <> struct default_interface<Windows::Devices::Gpio::GpioPinValueChangedEventArgs>{ using type = Windows::Devices::Gpio::IGpioPinValueChangedEventArgs; };
    template <> struct abi<Windows::Devices::Gpio::IGpioChangeCounter>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall put_Polarity(int32_t) noexcept = 0;
            virtual int32_t __stdcall get_Polarity(int32_t*) noexcept = 0;
            virtual int32_t __stdcall get_IsStarted(bool*) noexcept = 0;
            virtual int32_t __stdcall Start() noexcept = 0;
            virtual int32_t __stdcall Stop() noexcept = 0;
            virtual int32_t __stdcall Read(struct struct_Windows_Devices_Gpio_GpioChangeCount*) noexcept = 0;
            virtual int32_t __stdcall Reset(struct struct_Windows_Devices_Gpio_GpioChangeCount*) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Devices::Gpio::IGpioChangeCounterFactory>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall Create(void*, void**) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Devices::Gpio::IGpioChangeReader>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall get_Capacity(int32_t*) noexcept = 0;
            virtual int32_t __stdcall get_Length(int32_t*) noexcept = 0;
            virtual int32_t __stdcall get_IsEmpty(bool*) noexcept = 0;
            virtual int32_t __stdcall get_IsOverflowed(bool*) noexcept = 0;
            virtual int32_t __stdcall put_Polarity(int32_t) noexcept = 0;
            virtual int32_t __stdcall get_Polarity(int32_t*) noexcept = 0;
            virtual int32_t __stdcall get_IsStarted(bool*) noexcept = 0;
            virtual int32_t __stdcall Start() noexcept = 0;
            virtual int32_t __stdcall Stop() noexcept = 0;
            virtual int32_t __stdcall Clear() noexcept = 0;
            virtual int32_t __stdcall GetNextItem(struct struct_Windows_Devices_Gpio_GpioChangeRecord*) noexcept = 0;
            virtual int32_t __stdcall PeekNextItem(struct struct_Windows_Devices_Gpio_GpioChangeRecord*) noexcept = 0;
            virtual int32_t __stdcall GetAllItems(void**) noexcept = 0;
            virtual int32_t __stdcall WaitForItemsAsync(int32_t, void**) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Devices::Gpio::IGpioChangeReaderFactory>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall Create(void*, void**) noexcept = 0;
            virtual int32_t __stdcall CreateWithCapacity(void*, int32_t, void**) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Devices::Gpio::IGpioController>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall get_PinCount(int32_t*) noexcept = 0;
            virtual int32_t __stdcall OpenPin(int32_t, void**) noexcept = 0;
            virtual int32_t __stdcall OpenPinWithSharingMode(int32_t, int32_t, void**) noexcept = 0;
            virtual int32_t __stdcall TryOpenPin(int32_t, int32_t, void**, int32_t*, bool*) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Devices::Gpio::IGpioControllerStatics>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall GetDefault(void**) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Devices::Gpio::IGpioControllerStatics2>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall GetControllersAsync(void*, void**) noexcept = 0;
            virtual int32_t __stdcall GetDefaultAsync(void**) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Devices::Gpio::IGpioPin>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall add_ValueChanged(void*, winrt::event_token*) noexcept = 0;
            virtual int32_t __stdcall remove_ValueChanged(winrt::event_token) noexcept = 0;
            virtual int32_t __stdcall get_DebounceTimeout(int64_t*) noexcept = 0;
            virtual int32_t __stdcall put_DebounceTimeout(int64_t) noexcept = 0;
            virtual int32_t __stdcall get_PinNumber(int32_t*) noexcept = 0;
            virtual int32_t __stdcall get_SharingMode(int32_t*) noexcept = 0;
            virtual int32_t __stdcall IsDriveModeSupported(int32_t, bool*) noexcept = 0;
            virtual int32_t __stdcall GetDriveMode(int32_t*) noexcept = 0;
            virtual int32_t __stdcall SetDriveMode(int32_t) noexcept = 0;
            virtual int32_t __stdcall Write(int32_t) noexcept = 0;
            virtual int32_t __stdcall Read(int32_t*) noexcept = 0;
        };
    };
    template <> struct abi<Windows::Devices::Gpio::IGpioPinValueChangedEventArgs>
    {
        struct __declspec(novtable) type : inspectable_abi
        {
            virtual int32_t __stdcall get_Edge(int32_t*) noexcept = 0;
        };
    };
    template <typename D>
    struct consume_Windows_Devices_Gpio_IGpioChangeCounter
    {
        WINRT_IMPL_AUTO(void) Polarity(Windows::Devices::Gpio::GpioChangePolarity const& value) const;
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Devices::Gpio::GpioChangePolarity) Polarity() const;
        [[nodiscard]] WINRT_IMPL_AUTO(bool) IsStarted() const;
        WINRT_IMPL_AUTO(void) Start() const;
        WINRT_IMPL_AUTO(void) Stop() const;
        WINRT_IMPL_AUTO(Windows::Devices::Gpio::GpioChangeCount) Read() const;
        WINRT_IMPL_AUTO(Windows::Devices::Gpio::GpioChangeCount) Reset() const;
    };
    template <> struct consume<Windows::Devices::Gpio::IGpioChangeCounter>
    {
        template <typename D> using type = consume_Windows_Devices_Gpio_IGpioChangeCounter<D>;
    };
    template <typename D>
    struct consume_Windows_Devices_Gpio_IGpioChangeCounterFactory
    {
        WINRT_IMPL_AUTO(Windows::Devices::Gpio::GpioChangeCounter) Create(Windows::Devices::Gpio::GpioPin const& pin) const;
    };
    template <> struct consume<Windows::Devices::Gpio::IGpioChangeCounterFactory>
    {
        template <typename D> using type = consume_Windows_Devices_Gpio_IGpioChangeCounterFactory<D>;
    };
    template <typename D>
    struct consume_Windows_Devices_Gpio_IGpioChangeReader
    {
        [[nodiscard]] WINRT_IMPL_AUTO(int32_t) Capacity() const;
        [[nodiscard]] WINRT_IMPL_AUTO(int32_t) Length() const;
        [[nodiscard]] WINRT_IMPL_AUTO(bool) IsEmpty() const;
        [[nodiscard]] WINRT_IMPL_AUTO(bool) IsOverflowed() const;
        WINRT_IMPL_AUTO(void) Polarity(Windows::Devices::Gpio::GpioChangePolarity const& value) const;
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Devices::Gpio::GpioChangePolarity) Polarity() const;
        [[nodiscard]] WINRT_IMPL_AUTO(bool) IsStarted() const;
        WINRT_IMPL_AUTO(void) Start() const;
        WINRT_IMPL_AUTO(void) Stop() const;
        WINRT_IMPL_AUTO(void) Clear() const;
        WINRT_IMPL_AUTO(Windows::Devices::Gpio::GpioChangeRecord) GetNextItem() const;
        WINRT_IMPL_AUTO(Windows::Devices::Gpio::GpioChangeRecord) PeekNextItem() const;
        WINRT_IMPL_AUTO(Windows::Foundation::Collections::IVector<Windows::Devices::Gpio::GpioChangeRecord>) GetAllItems() const;
        WINRT_IMPL_AUTO(Windows::Foundation::IAsyncAction) WaitForItemsAsync(int32_t count) const;
    };
    template <> struct consume<Windows::Devices::Gpio::IGpioChangeReader>
    {
        template <typename D> using type = consume_Windows_Devices_Gpio_IGpioChangeReader<D>;
    };
    template <typename D>
    struct consume_Windows_Devices_Gpio_IGpioChangeReaderFactory
    {
        WINRT_IMPL_AUTO(Windows::Devices::Gpio::GpioChangeReader) Create(Windows::Devices::Gpio::GpioPin const& pin) const;
        WINRT_IMPL_AUTO(Windows::Devices::Gpio::GpioChangeReader) CreateWithCapacity(Windows::Devices::Gpio::GpioPin const& pin, int32_t minCapacity) const;
    };
    template <> struct consume<Windows::Devices::Gpio::IGpioChangeReaderFactory>
    {
        template <typename D> using type = consume_Windows_Devices_Gpio_IGpioChangeReaderFactory<D>;
    };
    template <typename D>
    struct consume_Windows_Devices_Gpio_IGpioController
    {
        [[nodiscard]] WINRT_IMPL_AUTO(int32_t) PinCount() const;
        WINRT_IMPL_AUTO(Windows::Devices::Gpio::GpioPin) OpenPin(int32_t pinNumber) const;
        WINRT_IMPL_AUTO(Windows::Devices::Gpio::GpioPin) OpenPin(int32_t pinNumber, Windows::Devices::Gpio::GpioSharingMode const& sharingMode) const;
        WINRT_IMPL_AUTO(bool) TryOpenPin(int32_t pinNumber, Windows::Devices::Gpio::GpioSharingMode const& sharingMode, Windows::Devices::Gpio::GpioPin& pin, Windows::Devices::Gpio::GpioOpenStatus& openStatus) const;
    };
    template <> struct consume<Windows::Devices::Gpio::IGpioController>
    {
        template <typename D> using type = consume_Windows_Devices_Gpio_IGpioController<D>;
    };
    template <typename D>
    struct consume_Windows_Devices_Gpio_IGpioControllerStatics
    {
        WINRT_IMPL_AUTO(Windows::Devices::Gpio::GpioController) GetDefault() const;
    };
    template <> struct consume<Windows::Devices::Gpio::IGpioControllerStatics>
    {
        template <typename D> using type = consume_Windows_Devices_Gpio_IGpioControllerStatics<D>;
    };
    template <typename D>
    struct consume_Windows_Devices_Gpio_IGpioControllerStatics2
    {
        WINRT_IMPL_AUTO(Windows::Foundation::IAsyncOperation<Windows::Foundation::Collections::IVectorView<Windows::Devices::Gpio::GpioController>>) GetControllersAsync(Windows::Devices::Gpio::Provider::IGpioProvider const& provider) const;
        WINRT_IMPL_AUTO(Windows::Foundation::IAsyncOperation<Windows::Devices::Gpio::GpioController>) GetDefaultAsync() const;
    };
    template <> struct consume<Windows::Devices::Gpio::IGpioControllerStatics2>
    {
        template <typename D> using type = consume_Windows_Devices_Gpio_IGpioControllerStatics2<D>;
    };
    template <typename D>
    struct consume_Windows_Devices_Gpio_IGpioPin
    {
        WINRT_IMPL_AUTO(winrt::event_token) ValueChanged(Windows::Foundation::TypedEventHandler<Windows::Devices::Gpio::GpioPin, Windows::Devices::Gpio::GpioPinValueChangedEventArgs> const& handler) const;
        using ValueChanged_revoker = impl::event_revoker<Windows::Devices::Gpio::IGpioPin, &impl::abi_t<Windows::Devices::Gpio::IGpioPin>::remove_ValueChanged>;
        [[nodiscard]] ValueChanged_revoker ValueChanged(auto_revoke_t, Windows::Foundation::TypedEventHandler<Windows::Devices::Gpio::GpioPin, Windows::Devices::Gpio::GpioPinValueChangedEventArgs> const& handler) const;
        WINRT_IMPL_AUTO(void) ValueChanged(winrt::event_token const& token) const noexcept;
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Foundation::TimeSpan) DebounceTimeout() const;
        WINRT_IMPL_AUTO(void) DebounceTimeout(Windows::Foundation::TimeSpan const& value) const;
        [[nodiscard]] WINRT_IMPL_AUTO(int32_t) PinNumber() const;
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Devices::Gpio::GpioSharingMode) SharingMode() const;
        WINRT_IMPL_AUTO(bool) IsDriveModeSupported(Windows::Devices::Gpio::GpioPinDriveMode const& driveMode) const;
        WINRT_IMPL_AUTO(Windows::Devices::Gpio::GpioPinDriveMode) GetDriveMode() const;
        WINRT_IMPL_AUTO(void) SetDriveMode(Windows::Devices::Gpio::GpioPinDriveMode const& value) const;
        WINRT_IMPL_AUTO(void) Write(Windows::Devices::Gpio::GpioPinValue const& value) const;
        WINRT_IMPL_AUTO(Windows::Devices::Gpio::GpioPinValue) Read() const;
    };
    template <> struct consume<Windows::Devices::Gpio::IGpioPin>
    {
        template <typename D> using type = consume_Windows_Devices_Gpio_IGpioPin<D>;
    };
    template <typename D>
    struct consume_Windows_Devices_Gpio_IGpioPinValueChangedEventArgs
    {
        [[nodiscard]] WINRT_IMPL_AUTO(Windows::Devices::Gpio::GpioPinEdge) Edge() const;
    };
    template <> struct consume<Windows::Devices::Gpio::IGpioPinValueChangedEventArgs>
    {
        template <typename D> using type = consume_Windows_Devices_Gpio_IGpioPinValueChangedEventArgs<D>;
    };
    struct struct_Windows_Devices_Gpio_GpioChangeCount
    {
        uint64_t Count;
        int64_t RelativeTime;
    };
    template <> struct abi<Windows::Devices::Gpio::GpioChangeCount>
    {
        using type = struct_Windows_Devices_Gpio_GpioChangeCount;
    };
    struct struct_Windows_Devices_Gpio_GpioChangeRecord
    {
        int64_t RelativeTime;
        int32_t Edge;
    };
    template <> struct abi<Windows::Devices::Gpio::GpioChangeRecord>
    {
        using type = struct_Windows_Devices_Gpio_GpioChangeRecord;
    };
}
#endif
