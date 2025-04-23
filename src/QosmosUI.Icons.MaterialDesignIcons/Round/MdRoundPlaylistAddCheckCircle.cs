// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundPlaylistAddCheckCircle : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "height", "24");
		builder.AddAttribute(16, "width", "24");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M12,2C6.48,2,2,6.48,2,12c0,5.52,4.48,10,10,10c5.52,0,10-4.48,10-10C22,6.48,17.52,2,12,2z M7,8c0-0.55,0.45-1,1-1h5 c0.55,0,1,0.45,1,1v0c0,0.55-0.45,1-1,1H8C7.45,9,7,8.55,7,8L7,8z M7,11c0-0.55,0.45-1,1-1h5c0.55,0,1,0.45,1,1v0c0,0.55-0.45,1-1,1 H8C7.45,12,7,11.55,7,11L7,11z M10,14c0,0.55-0.45,1-1,1H8c-0.55,0-1-0.45-1-1v0c0-0.55,0.45-1,1-1h1C9.55,13,10,13.45,10,14L10,14z M18.29,14.12l-3.54,3.54c-0.39,0.39-1.02,0.39-1.41,0l-1.41-1.41c-0.39-0.39-0.39-1.02,0-1.41c0.39-0.39,1.02-0.39,1.41,0 l0.71,0.71l2.83-2.83c0.39-0.39,1.02-0.39,1.41,0C18.68,13.1,18.68,13.73,18.29,14.12z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
