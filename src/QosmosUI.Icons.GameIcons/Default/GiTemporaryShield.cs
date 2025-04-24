// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiTemporaryShield : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 22C192 70 128 90 32 122c0 112 80 272 224 368 144-96 224-250 224-362-96-32-160-58-224-106zm0 97c75.6 0 137 61.4 137 137s-61.4 137-137 137-137-61.4-137-137 61.4-137 137-137zm-9 18.3c-42.9 3.2-79.3 29.1-97.6 65.6l97.9 39.9a16 17.12 0 0 1 8.7-2.8 16 17.12 0 0 1 2.9.3l38.7-38.7 12.8 12.8-38.8 38.8a16 17.12 0 0 1 .4 3.9 16 17.12 0 0 1-16 17.1 16 17.12 0 0 1-15.9-15l-97.4-39.7c-2.8 8.8-4.7 18-5.4 27.5H160v18h-22.7c4.4 58.6 51.1 105.3 109.7 109.7V352h18v22.7c58.6-4.4 105.3-51.1 109.7-109.7H352v-18h22.7c-4.4-58.6-51.1-105.3-109.7-109.7V160h-18v-22.7z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
