// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundLeakRemove : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M20.12 12.04c.5-.05.88-.48.88-.99 0-.59-.51-1.06-1.1-1-1.5.15-2.9.61-4.16 1.3l1.48 1.48c.9-.41 1.87-.69 2.9-.79zm.88 3.05c0-.61-.54-1.09-1.14-1-.38.06-.75.16-1.11.28l1.62 1.62c.37-.15.63-.49.63-.9zM13.97 4.14c.06-.59-.4-1.11-1-1.11-.5 0-.94.37-.99.87-.1 1.03-.38 2.01-.79 2.91l1.48 1.48c.69-1.26 1.15-2.66 1.3-4.15zm-4.04.02c.1-.6-.39-1.14-1-1.14-.41 0-.75.26-.9.62l1.62 1.62c.13-.35.22-.72.28-1.1zm10.51 14.72L5.12 3.56c-.39-.39-1.02-.39-1.41 0-.39.39-.39 1.02 0 1.41l2.15 2.15c-.59.41-1.26.7-1.99.82-.48.1-.84.5-.84 1 0 .61.54 1.09 1.14 1 1.17-.19 2.23-.68 3.13-1.37L8.73 10c-1.34 1.1-3 1.82-4.81 1.99-.5.05-.88.48-.88.99 0 .59.51 1.06 1.1 1 2.28-.23 4.36-1.15 6.01-2.56l2.48 2.48c-1.4 1.65-2.33 3.72-2.56 6-.06.59.4 1.11 1 1.11.5 0 .94-.37.99-.87.18-1.82.9-3.48 1.99-4.82l1.43 1.43c-.69.9-1.18 1.96-1.37 3.13-.1.6.39 1.14 1 1.14.49 0 .9-.36.98-.85.12-.73.42-1.4.82-1.99l2.13 2.13c.39.39 1.02.39 1.41 0 .38-.41.38-1.04-.01-1.43z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
