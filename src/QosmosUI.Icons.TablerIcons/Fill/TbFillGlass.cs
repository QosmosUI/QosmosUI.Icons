// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillGlass : ComponentBase
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
		builder.AddAttribute(14, "d", "M12 2c3.205 0 5.894 1.05 5.997 2.89l.99 5.946l.013 .164c0 3.226 -2.56 5.564 -6 5.945v3.055h3a1 1 0 0 1 0 2h-8a1 1 0 0 1 0 -2h3v-3.055c-3.44 -.38 -6 -2.719 -6 -5.945l.014 -.164l.991 -5.955l.001 -.038c.146 -1.81 2.817 -2.843 5.994 -2.843m0 2c-1.224 0 -2.359 .192 -3.164 .514c-.594 .238 -.836 .467 -.836 .486c0 .02 .242 .248 .836 .486c.804 .322 1.94 .514 3.164 .514s2.359 -.192 3.164 -.514c.594 -.238 .836 -.467 .836 -.486l-.02 -.026c-.07 -.07 -.321 -.262 -.816 -.46c-.804 -.322 -1.94 -.514 -3.164 -.514");
		builder.CloseElement();
		builder.CloseElement();
    }
}
