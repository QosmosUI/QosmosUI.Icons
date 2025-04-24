// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiQlik : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "m23.7515 20.1367-3.13-2.6326c1.0862-1.7307 1.7303-3.7745 1.7303-5.9655 0-6.1684-5.008-11.1764-11.176-11.1764S0 5.3702 0 11.5386c0 6.168 5.008 11.176 11.1759 11.176 2.3934 0 4.6216-.7552 6.4443-2.0438l3.3324 2.7988s.4974.4236.921-.0738l1.9884-2.3568c-.0186 0 .3864-.4968-.1105-.9023zm-5.7078-8.598c0 3.7926-3.0747 6.8672-6.8678 6.8672-3.7926 0-6.8678-3.0746-6.8678-6.8673 0-3.793 3.0752-6.8678 6.8678-6.8678 3.7931 0 6.8678 3.0747 6.8678 6.8678zm-11.287 0c0-2.4304 1.9702-4.4006 4.4006-4.4006 2.4303 0 4.4005 1.9702 4.4005 4.4005 0 2.4304-1.9702 4.4006-4.4005 4.4006-2.4304 0-4.4005-1.9702-4.4005-4.4006z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
