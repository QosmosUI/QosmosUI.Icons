// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Heroicons.Mini;

public class HiMiniGiftTop : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 20 20";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "d", "M9.25 3H3.5A1.5 1.5 0 0 0 2 4.5v4.75h3.365A2.75 2.75 0 0 1 9.25 5.362V3ZM2 10.75v4.75A1.5 1.5 0 0 0 3.5 17h5.75v-4.876A4.75 4.75 0 0 1 5 14.75a.75.75 0 0 1 0-1.5 3.251 3.251 0 0 0 3.163-2.5H2ZM10.75 17h5.75a1.5 1.5 0 0 0 1.5-1.5v-4.75h-6.163A3.251 3.251 0 0 0 15 13.25a.75.75 0 0 1 0 1.5 4.75 4.75 0 0 1-4.25-2.626V17ZM18 9.25V4.5A1.5 1.5 0 0 0 16.5 3h-5.75v2.362a2.75 2.75 0 0 1 3.885 3.888H18Zm-4.496-2.755a1.25 1.25 0 0 0-1.768 0c-.36.359-.526.999-.559 1.697-.01.228-.006.443.004.626.183.01.398.014.626.003.698-.033 1.338-.2 1.697-.559a1.25 1.25 0 0 0 0-1.767Zm-5.24 0a1.25 1.25 0 0 0-1.768 1.767c.36.36 1 .526 1.697.56.228.01.443.006.626-.004.01-.183.015-.398.004-.626-.033-.698-.2-1.338-.56-1.697Z");
		builder.AddAttribute(16, "clip-rule", "evenodd");
		builder.CloseElement();
		builder.CloseElement();
    }
}
