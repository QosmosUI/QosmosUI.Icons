// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiAlx : ComponentBase
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
		builder.AddAttribute(15, "d", "m13.732 5.879-2.903 1.299V18.12h2.903V5.879Zm3.219 1.436c-.361.36-1.59 1.587-1.977 1.978.839.851 1.684 1.696 2.527 2.543l-2.529 2.529 1.978 1.978c.844-.842 1.686-1.686 2.529-2.529l2.543 2.529c.66-.659 1.319-1.319 1.978-1.98-.848-.841-1.695-1.684-2.543-2.527L24 9.293l-1.978-1.978-2.543 2.543-2.528-2.543ZM6.157 9.271v.382C3.256 8.379.002 10.503 0 13.671c.001 3.169 3.256 5.293 6.157 4.018v.431H9.06V9.271H6.157ZM4.39 11.902c.978 0 1.718.741 1.767 1.674v.19a1.77 1.77 0 0 1-1.767 1.675c-.946 0-1.77-.792-1.77-1.77s.792-1.77 1.77-1.77v.001Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
