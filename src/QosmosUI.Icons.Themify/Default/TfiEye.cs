// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiEye : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M16.965 8.817c-1.284-3.267-4.687-5.463-8.465-5.463s-7.181 2.196-8.465 5.463c-0.046 0.117-0.046 0.248 0 0.365 1.285 3.268 4.687 5.464 8.465 5.464s7.18-2.195 8.465-5.463c0.047-0.118 0.047-0.248 0-0.366zM8.5 13.646c-3.298 0-6.269-1.859-7.459-4.646 1.189-2.787 4.16-4.646 7.459-4.646s6.27 1.859 7.459 4.646c-1.19 2.786-4.161 4.646-7.459 4.646zM8.5 5.357c-2.009 0-3.643 1.634-3.643 3.643s1.634 3.643 3.644 3.643c2.008 0 3.643-1.634 3.643-3.643s-1.635-3.643-3.644-3.643zM8.5 11.643c-1.458 0-2.644-1.186-2.644-2.643s1.187-2.643 2.644-2.643c1.457 0 2.643 1.186 2.643 2.643s-1.185 2.643-2.643 2.643zM8.5 7.643c-0.748 0-1.357 0.609-1.357 1.357s0.609 1.357 1.357 1.357 1.357-0.609 1.357-1.357-0.609-1.357-1.357-1.357zM8.5 9.357c-0.197 0-0.357-0.16-0.357-0.357s0.16-0.357 0.357-0.357 0.357 0.16 0.357 0.357-0.16 0.357-0.357 0.357z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
