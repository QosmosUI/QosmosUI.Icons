// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiDuel : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M76 16v110.625s21.708-11.927 32.343-9.843c15.5 1.78 28.554 14.896 30.468 24.375-12.995 2.602-22.967 16.39-22.967 32.812 0 18.283 12.508 33.28 27.657 33.28 1.462 0 4.692.73 6.093.47l37.968 158.906V496h51.094V108.345l-25.313 18.282s-8.972-27.62-34.686-55.312C152.94 43.624 75.997 16.002 75.997 16.002zm197.343 0v387.657l25.312-18.282s8.973 27.62 34.688 55.313C359.057 468.38 436 496 436 496V385.375s-21.708 11.927-32.343 9.843c-15.5-1.78-28.554-14.896-30.468-24.375 12.995-2.603 22.967-16.39 22.967-32.813 0-18.283-12.508-33.28-27.657-33.28-1.462 0-4.692-.73-6.093-.47L324.44 145.375V16h-51.094z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
