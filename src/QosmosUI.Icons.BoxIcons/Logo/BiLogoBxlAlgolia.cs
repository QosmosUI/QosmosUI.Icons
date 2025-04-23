// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Logo;

public class BiLogoBxlAlgolia : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M12.177 9.059a3.582 3.582 0 0 0-3.576 3.584 3.584 3.584 0 0 0 3.576 3.585 3.578 3.578 0 0 0 3.575-3.585 3.582 3.582 0 0 0-3.575-3.584zm2.518 2.268-2.366 1.229c-.07.039-.153-.017-.153-.093V9.791h.001c0-.06.054-.104.109-.104a2.943 2.943 0 0 1 2.452 1.492c.028.055.011.121-.043.148z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M18.578 3H5.361A2.363 2.363 0 0 0 3 5.366v13.277a2.368 2.368 0 0 0 2.361 2.371h13.217a2.367 2.367 0 0 0 2.361-2.372V5.372A2.368 2.368 0 0 0 18.578 3zm-8.112 3.404a.78.78 0 0 1 .779-.781h1.815c.43 0 .778.35.778.781v.618a.106.106 0 0 1-.131.104 5.677 5.677 0 0 0-3.106.017c-.07.016-.136-.033-.136-.104v-.635zM7.08 8.993a.78.78 0 0 1 .001-1.103l.371-.371.002-.002a.776.776 0 0 1 1.099.002l.31.311c.043.05.038.127-.017.159a5.82 5.82 0 0 0-1.296 1.3c-.044.049-.114.06-.163.011l-.306-.306-.001-.001zm5.097 8.737a5.078 5.078 0 0 1-5.074-5.087c0-2.813 2.272-5.092 5.074-5.092a5.074 5.074 0 0 1 5.074 5.086c0 2.815-2.272 5.093-5.074 5.093z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
