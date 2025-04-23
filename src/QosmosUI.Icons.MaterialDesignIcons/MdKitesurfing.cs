// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons;

public class MdKitesurfing : ComponentBase
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
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M6,3c0-1.1,0.9-2,2-2s2,0.9,2,2c0,1.1-0.9,2-2,2S6,4.1,6,3z M20.06,1h-2.12L15.5,3.44l1.06,1.06L20.06,1z M22,23v-2h-1 c-1.04,0-2.08-0.35-3-1c-1.83,1.3-4.17,1.3-6,0c-1.83,1.3-4.17,1.3-6,0c-0.91,0.65-1.96,1-3,1H2l0,2h1c1.03,0,2.05-0.25,3-0.75 c1.89,1,4.11,1,6,0c1.89,1,4.11,1,6,0h0c0.95,0.5,1.97,0.75,3,0.75H22z M21,13.28c0,1.44-2.19,3.62-5.04,5.58 C15.65,18.95,15.33,19,15,19c-1.2,0-2.27-0.66-3-1.5c-0.73,0.84-1.8,1.5-3,1.5c-0.94,0-1.81-0.41-2.49-0.99 c0.46-0.39,0.96-0.78,1.49-1.17l-1.55-2.97C6.15,13.3,6,12.64,6,12V8c0-1.1,0.9-2,2-2h3c1.38,0,2.63-0.56,3.54-1.46l1.41,1.41 C14.68,7.21,12.93,8,11,8H9.6l0,3.5h2.8l1.69,1.88c1.95-0.84,3.77-1.38,5.06-1.38C19.99,12,21,12.25,21,13.28z M12.2,14.27 l-0.7-0.77L9,13.6l0.83,2.01C10.42,15.23,11.64,14.55,12.2,14.27z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
