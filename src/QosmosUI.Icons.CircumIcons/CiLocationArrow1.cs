// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiLocationArrow1 : ComponentBase
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
		builder.AddAttribute(14, "id", "Location_Arrow_1");
		builder.AddAttribute(15, "data-name", "Location Arrow 1");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M14.472,20.937a1.438,1.438,0,0,1-1.3-.812L10.3,14.343a1.418,1.418,0,0,0-.642-.641L3.874,10.831A1.462,1.462,0,0,1,4.06,8.136l14.952-5a1.46,1.46,0,0,1,1.849,1.847l-5,14.952a1.439,1.439,0,0,1-1.284.994C14.543,20.936,14.507,20.937,14.472,20.937ZM19.479,4.063a.488.488,0,0,0-.149.024h0l-14.952,5a.46.46,0,0,0-.058.849L10.1,12.805A2.444,2.444,0,0,1,11.2,13.9l2.87,5.782a.443.443,0,0,0,.445.255.45.45,0,0,0,.4-.312l5-14.953a.462.462,0,0,0-.433-.607Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
