// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiPalisade : ComponentBase
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
		builder.AddAttribute(14, "d", "M112 144.836l-9 48V279h18v-86.164l-9-48zm36 0l-9 48V279h18v-86.164l-9-48zm216 0l-9 48V279h18v-86.164l-9-48zm36 0l-9 48V279h18v-86.164l-9-48zm-360 64l-9 48V279h18v-22.164l-9-48zm36 0l-9 48V279h18v-22.164l-9-48zm108 0l-9 48V279h18v-22.164l-9-48zm36 0l-9 48V279h18v-22.164l-9-48zm36 0l-9 48V279h18v-22.164l-9-48zm36 0l-9 48V279h18v-22.164l-9-48zm36 0l-9 48V279h18v-22.164l-9-48zm108 0l-9 48V279h18v-22.164l-9-48zm36 0l-9 48V279h18v-22.164l-9-48zM18 297v16h138.96v-16H18zm156.96 0v16h162.005v-16H174.96zm180.005 0v16H494v-16H354.965zM31 331v156h18V331H31zm36 0v156h18V331H67zm36 0v156h18V331h-18zm36 0v156h18V331h-18zm36 0v156h18V331h-18zm36 0v156h18V331h-18zm36 0v156h18V331h-18zm36 0v156h18V331h-18zm36 0v156h18V331h-18zm36 0v156h18V331h-18zm36 0v156h18V331h-18zm36 0v156h18V331h-18zm36 0v156h18V331h-18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
