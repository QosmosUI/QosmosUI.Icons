// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Regular;

public class BiRegBxStation : ComponentBase
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
		builder.OpenElement(13, "circle");
		builder.AddAttribute(14, "cx", "12");
		builder.AddAttribute(15, "cy", "12");
		builder.AddAttribute(16, "r", "2");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "m7.758 16.243 1.414-1.415a3.97 3.97 0 0 1-1.173-2.831c0-1.068.417-2.071 1.173-2.825L7.758 7.756a5.957 5.957 0 0 0-1.76 4.24c0 1.604.625 3.112 1.76 4.247zm8.484 0A5.96 5.96 0 0 0 18 12a5.96 5.96 0 0 0-1.758-4.243l-1.414 1.414C15.584 9.927 16 10.932 16 12s-.416 2.073-1.172 2.829l1.414 1.414z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M6.344 17.657a7.953 7.953 0 0 1-2.345-5.659c0-2.137.833-4.145 2.345-5.654L4.93 4.929c-1.89 1.886-2.931 4.397-2.931 7.069s1.041 5.183 2.931 7.073l1.414-1.414zM17.657 6.343A7.948 7.948 0 0 1 20 12a7.948 7.948 0 0 1-2.343 5.657l1.414 1.414A9.932 9.932 0 0 0 22 12a9.934 9.934 0 0 0-2.929-7.071l-1.414 1.414z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
