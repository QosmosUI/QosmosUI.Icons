// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcDribbble : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "48px";

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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.AddAttribute(14, "fill", "#FF4081");
		builder.AddAttribute(15, "d", "M42,37c0,2.762-2.238,5-5,5H11c-2.761,0-5-2.238-5-5V11c0-2.762,2.239-5,5-5h26c2.762,0,5,2.238,5,5V37z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#FFFFFF");
		builder.AddAttribute(18, "d", "M33.061,26.273c-0.703-0.221-1.464,0.175-1.686,0.895c-0.824,2.658-2.316,5.419-2.993,5.57	c-0.507,0-1.236-0.43-1.958-1.44c1.674-3.594,2.551-8.106,2.551-11.118c0-8.413-2.124-10.18-3.908-10.18	c-3.757,0-3.8,9.912-3.8,10.012c0,1.166,0.042,2.248,0.121,3.256c-0.518-0.189-1.113-0.319-1.77-0.319	c-3.86,0-5.618,3.809-5.618,7.347C14,33.63,15.871,37,20.046,37c1.972,0,3.634-1.291,4.975-3.221	c1.188,1.235,2.432,1.696,3.36,1.696c2.923,0,4.858-5.233,5.556-7.486C34.16,27.27,33.767,26.502,33.061,26.273z M20.048,34.264	c-3.031,0-3.36-2.775-3.36-3.969c0-0.188,0.034-4.611,2.932-4.611c1.144,0,2.022,0.885,2.022,0.885	c0.065,0.07,0.137,0.131,0.212,0.184c0.375,1.904,0.904,3.426,1.516,4.632C22.366,33.123,21.203,34.264,20.048,34.264z	 M24.901,27.926c-0.559-1.93-0.946-4.521-0.946-7.914c0-3.126,0.666-6.068,1.219-7.073c0.424,0.644,1.115,2.65,1.115,7.241	C26.289,22.616,25.75,25.446,24.901,27.926z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
