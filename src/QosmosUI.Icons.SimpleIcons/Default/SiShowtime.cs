// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiShowtime : ComponentBase
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
		builder.AddAttribute(15, "d", "M16.99 12.167c0-4.808 1.779-7.84 3.903-8.16C18.769 1.397 15.221 0 11.999 0 8.451 0 5.265 1.54 3.07 3.985c2.094.416 2.806 2.174 2.806 4.892H3.314c0-1.605-.334-2.436-1.284-2.436-.427 0-.758.217-.954.587-.027.06-.057.122-.084.184a2.115 2.115 0 0 0-.114.71c0 3.324 5.46 3.159 5.46 8.27 0 1.995-1.53 3.855-3.252 3.855C5.35 22.52 8.441 24 12 24c3.46 0 6.577-1.464 8.766-3.808-2.018-.509-3.776-3.413-3.776-8.025zm-1.142 7.921h-2.746V13.26h-2.967v6.83H7.384V4.327h2.746v6.348h2.972V4.327h2.746v15.761zM2.372 17.58c-1.32 0-2.399-2.32-2.372-5.8 1.905 1.72 3.681 2.11 3.681 4.145 0 .981-.543 1.655-1.309 1.655zM24 12.002c0 2.844-.896 5.409-2.1 5.409-1.445 0-2.181-2.703-2.181-5.498 0-2.654.771-5.308 2.181-5.308 1.676 0 2.1 4.102 2.1 5.397z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
