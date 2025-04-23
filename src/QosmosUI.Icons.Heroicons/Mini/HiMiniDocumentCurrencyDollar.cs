// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Heroicons.Mini;

public class HiMiniDocumentCurrencyDollar : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 20 20";

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
		builder.AddAttribute(15, "d", "M4.5 2A1.5 1.5 0 0 0 3 3.5v13A1.5 1.5 0 0 0 4.5 18h11a1.5 1.5 0 0 0 1.5-1.5V7.621a1.5 1.5 0 0 0-.44-1.06l-4.12-4.122A1.5 1.5 0 0 0 11.378 2H4.5Zm6.25 3.75a.75.75 0 0 0-1.5 0v.272c-.418.024-.831.069-1.238.132-.962.15-1.807.882-1.95 1.928-.04.3-.062.607-.062.918 0 1.044.83 1.759 1.708 1.898l1.542.243v2.334a11.214 11.214 0 0 1-2.297-.392.75.75 0 0 0-.405 1.444c.867.243 1.772.397 2.702.451v.272a.75.75 0 0 0 1.5 0v-.272c.419-.024.832-.069 1.239-.132.961-.15 1.807-.882 1.95-1.928.04-.3.061-.607.061-.918 0-1.044-.83-1.759-1.708-1.898L10.75 9.86V7.525c.792.052 1.56.185 2.297.392a.75.75 0 0 0 .406-1.444 12.723 12.723 0 0 0-2.703-.451V5.75ZM8.244 7.636c.33-.052.666-.09 1.006-.111v2.097l-1.308-.206C7.635 9.367 7.5 9.156 7.5 9c0-.243.017-.482.049-.716.042-.309.305-.587.695-.648Zm2.506 5.84v-2.098l1.308.206c.307.049.442.26.442.416 0 .243-.016.482-.048.716-.042.309-.306.587-.695.648-.331.052-.667.09-1.007.111Z");
		builder.AddAttribute(16, "clip-rule", "evenodd");
		builder.CloseElement();
		builder.CloseElement();
    }
}
