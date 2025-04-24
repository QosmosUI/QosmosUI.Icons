// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscCoverage : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M8.88415 8.32009L6.38415 11.3201L5.64648 11.3535L4.14648 9.85355L4.85359 9.14644L5.96644 10.2593L8.11593 7.6799L8.88415 8.32009Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M11.9803 9.96948C12.6105 9.33654 13 8.46376 13 7.5C13 5.567 11.433 4 9.5 4C9.03097 4 8.58349 4.09226 8.17472 4.25962C7.69756 4.10726 7.19209 4.01826 6.66821 4.00252C7.44155 3.37561 8.42691 3 9.5 3C11.9853 3 14 5.01472 14 7.5C14 9.2103 13.0459 10.6978 11.6408 11.4591C11.8197 10.99 11.9362 10.4901 11.9803 9.96948Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill-rule", "evenodd");
		builder.AddAttribute(21, "clip-rule", "evenodd");
		builder.AddAttribute(22, "d", "M6.5 13C4.567 13 3 11.433 3 9.5C3 7.567 4.567 6 6.5 6C8.433 6 10 7.567 10 9.5C10 11.433 8.433 13 6.5 13ZM6.5 14C8.98528 14 11 11.9853 11 9.5C11 7.01472 8.98528 5 6.5 5C4.01472 5 2 7.01472 2 9.5C2 11.9853 4.01472 14 6.5 14Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
