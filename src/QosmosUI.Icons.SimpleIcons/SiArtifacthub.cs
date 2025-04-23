// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiArtifacthub : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.9999 24.00044c-.617.0012-1.24209-.17217-1.78008-.50002l-7.50975-4.29263c-1.01763-.61684-1.64001-1.71772-1.64066-2.9077V7.72971c0-1.25305.63694-2.36948 1.76008-3.01013L10.25041.47895c1.08003-.63867 2.41512-.63767 3.49515.001l7.41975 4.23763c1.08007.59613 1.7714 1.7341 1.76266 3.01013v8.58195c0 .96773-.44338 2.16388-1.63666 2.89856l-7.51074 4.2922c-.56347.34395-1.19861.50002-1.78167.50002zm-.50002-21.34695L3.95513 6.96224c-.2006.1567-.37906.36914-.37902.76747l.001 8.67039c.03753.22045.11891.42808.37302.63459l7.55975 4.31663c.26601.172.66403.21.98504 0l7.51792-4.29663c.23173-.14844.37102-.38858.41002-.65359V7.72971c.0095-.29884-.13595-.5886-.37702-.76547L12.49993 2.6525c-.39058-.23932-.7592-.15575-1.00004.001z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
