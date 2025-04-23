// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Logo;

public class BiLogoBxlDrupal : ComponentBase
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
		builder.AddAttribute(14, "d", "M11.474 14.42a3.162 3.162 0 1 0 0 6.324 3.162 3.162 0 0 0 0-6.324zm3.936-.606a5.433 5.433 0 0 1 1.513 3.769 5.441 5.441 0 0 1-2.335 4.47c2.609-.803 4.771-2.767 5.737-5.142 1.338-3.288.09-5.761-1.999-8.005.066.288.103.592.103.898a4.175 4.175 0 0 1-3.019 4.01zm-3.577-4.003c0 1.34 1.087 2.419 2.42 2.419s2.423-1.087 2.423-2.419a2.418 2.418 0 0 0-2.417-2.417 2.425 2.425 0 0 0-2.426 2.417z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M7.303 21.093a5.435 5.435 0 0 1-1.276-3.51 5.441 5.441 0 0 1 4.8-5.408 4.162 4.162 0 0 1 3.99-6.492c-1.361-1.176-2.724-2.369-3.799-3.672.547 5.714-5.2 3.638-7.332 8.904-1.422 3.527-.138 7.892 3.617 10.178z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
