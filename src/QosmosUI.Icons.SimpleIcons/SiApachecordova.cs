// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiApachecordova : ComponentBase
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
		builder.AddAttribute(15, "d", "M18.545,0.545H5.455L0,9.273l2.182,14.182h3.886l-0.273-3.273h1.909l0.273,3.273 h8.045l0.273-3.273h1.909l-0.273,3.273h3.886L24,9.273L18.545,0.545z M18.545,18H5.455L4.364,9.273l2.182-4.364h3.506L9.818,6.545 h4.364l-0.234-1.636h3.506l2.182,4.364L18.545,18z M15.545,11.045c0.301,0,0.545,0.908,0.545,2.029 c0,1.121-0.244,2.029-0.545,2.029c-0.301,0-0.545-0.908-0.545-2.029C15,11.954,15.244,11.045,15.545,11.045z M8.659,11.215 c0.301,0,0.545,0.908,0.545,2.029c0,1.121-0.244,2.029-0.545,2.029c-0.301,0-0.545-0.908-0.545-2.029 C8.114,12.123,8.358,11.215,8.659,11.215z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
