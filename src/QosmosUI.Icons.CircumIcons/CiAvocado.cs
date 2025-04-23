// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiAvocado : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Avocado");
		builder.OpenElement(15, "g");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M11.982,21.939a7.759,7.759,0,0,1-.818-.044A7.58,7.58,0,0,1,6.1,9.6a3.578,3.578,0,0,0,.684-2.271,5.128,5.128,0,0,1,3.8-5.085,5.266,5.266,0,0,1,4.6.892,5.185,5.185,0,0,1,2.039,4.14A3.6,3.6,0,0,0,17.9,9.61a7.574,7.574,0,0,1-5.918,12.329Zm.009-18.877a4.538,4.538,0,0,0-1.158.152,4.126,4.126,0,0,0-3.055,4.07,4.532,4.532,0,0,1-.9,2.947,6.555,6.555,0,0,0-1.366,5.231A6.643,6.643,0,0,0,11.271,20.9a6.575,6.575,0,0,0,5.851-10.662,4.453,4.453,0,0,1-.9-2.9,4.214,4.214,0,0,0-4.228-4.273Z");
		builder.CloseElement();
		builder.OpenElement(18, "ellipse");
		builder.AddAttribute(19, "cx", "11.999");
		builder.AddAttribute(20, "cy", "14.856");
		builder.AddAttribute(21, "rx", "2.5");
		builder.AddAttribute(22, "ry", "3");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
