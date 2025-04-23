// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons;

public class GrFingerPrint : ComponentBase
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
		builder.AddAttribute(14, "fill", "none");
		builder.AddAttribute(15, "stroke-linecap", "round");
		builder.AddAttribute(16, "stroke-width", "2");
		builder.AddAttribute(17, "d", "M14,15 C14,13.8954305 13.1045695,13 12,13 C10.8954305,13 10,13.8954305 10,15 C10,16.1045695 10.8954305,17 12,17 L12,17 M12,20 C9.23857625,20 7,17.7614237 7,15 C7,12.2385763 9.23857625,10 12,10 C14.7614237,10 17,12.2385763 17,15 C17,15.8284271 17.6715729,16.5 18.5,16.5 C19.3284271,16.5 20,15.8284271 20,15 C20,10.581722 16.418278,7 12,7 C7.581722,7 4,10.581722 4,15 C4,19.418278 7.581722,23 12,23 L14,23 M1,15 C1,17.6720798 1.95275656,20.1216314 3.53708682,22.0274719 M20.5202529,8.04207866 C18.5030558,5.574886 15.4354451,4 12,4 C8.59642702,4 5.55389491,5.54579976 3.53616098,7.97364199 M18.5259055,2.61083013 C16.577286,1.58228463 14.3566429,1 12,1 C9.66126395,1 7.45646883,1.57346929 5.51856118,2.58746134");
		builder.CloseElement();
		builder.CloseElement();
    }
}
