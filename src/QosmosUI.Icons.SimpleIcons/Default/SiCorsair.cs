// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiCorsair : ComponentBase
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
		builder.AddAttribute(15, "d", "M13.072.412s1.913 3.881 1.563 5.5c0 0 4.987 1.612 5.54 4.272 0 0 2.73-3.594-7.103-9.772zM7.908 4.067s1.678 2.625 1.417 4.35l2.818 1.067a17.56 17.56 0 0 0-.991-3.248zm3.784.691a14.162 14.162 0 0 1 .163 13.794 17.702 17.702 0 0 0 .594-6.585c-.017-.186-.031-.368-.053-.55L6.908 7.759a14.13 14.13 0 0 1 1.133 4.465 14.02 14.02 0 0 1-1.305 7.347 17.75 17.75 0 0 0 .442-5.988.92.92 0 0 1-.022-.243l-5.133-2.726a11.639 11.639 0 0 1 1.075 3.93A11.785 11.785 0 0 1 0 23.587c21.91-9.29 22.795-3.173 22.795-3.173s1.656-2.164 1.085-4.51C23.128 12.79 11.692 4.759 11.692 4.759zM3.04 7.245s1.629 2.09 1.363 3.815l2.567.637a20.357 20.357 0 0 0-.863-2.788z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
