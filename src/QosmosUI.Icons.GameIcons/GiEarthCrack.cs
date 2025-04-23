// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiEarthCrack : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 512 512";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M156.777 16.248l21.832 149.004-83.165-78.248 40.946 125.732-74.765-6.927 39.33 68.112h71.87l-11.512-38.73 28.125 15.234 1.17-49.223 44.537 51.568 14.064-78.52 17.58 60.94 57.425-39.846-17.58 58.597 55.082-22.266-30.912 42.248h80.834l37.17-63.13-51.26 6.845 20.565-85.008-70.873 48.905L395.61 69.693l-95.25 51.473-12.266-100.908-51.576 104.803-32.53-87.51-18.517 18.18-28.693-39.482zm57.23 259.61l-48.064 34.892 20.48 27.527L59.384 355l8.42 66.527-.506 2.99-48.087 20.126V491.7h34.42l47.1-46.206-18.678-74.63 46.343-6.1 3.358 54.933 1.685.75 39.685 32.815-18.117 38.437h54.185L215 432.284l-65.352-26.19-2.673-43.777 73.43-9.666-28.182-37.886 53.593-38.91h-31.81zm60.124 0l49.722 58.437-74.63 35.61-4.355.222 52.588 62.935L266.69 491.7h72.033l-2.315-73.403L282.78 374.6l58.706-28.014 73.418 17.262-45.13 72.213 41.003 55.112.19.527h69.838l-78.51-55.122 14.45-35.62 77.86 30.75v-34.606l-68.937-15.215 18.912-30.26-101.807-23.934-44.103-51.836h-24.54z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
