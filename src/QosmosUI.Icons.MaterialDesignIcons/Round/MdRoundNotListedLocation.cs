// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundNotListedLocation : ComponentBase
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
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M12 2c-4.2 0-8 3.22-8 8.2 0 3.18 2.45 6.92 7.34 11.22.38.33.95.33 1.33 0C17.55 17.12 20 13.38 20 10.2 20 5.22 16.2 2 12 2zm.01 14c-.59 0-1.05-.47-1.05-1.05 0-.59.47-1.04 1.05-1.04.59 0 1.04.45 1.04 1.04 0 .58-.44 1.05-1.04 1.05zm2.51-6.17c-.63.93-1.23 1.21-1.56 1.81-.08.14-.13.26-.16.49-.05.39-.36.68-.75.68h-.03c-.44 0-.79-.38-.75-.82.03-.27.09-.57.25-.84.41-.73 1.18-1.16 1.63-1.8.48-.68.21-1.94-1.14-1.94-.61 0-1.01.32-1.26.7-.19.29-.57.39-.89.25-.42-.18-.6-.7-.34-1.07C10.03 6.55 10.88 6 12 6c1.23 0 2.08.56 2.51 1.26.36.61.58 1.73.01 2.57z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
