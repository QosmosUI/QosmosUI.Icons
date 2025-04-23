// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Regular;

public class BiRegBxSticker : ComponentBase
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
		builder.AddAttribute(14, "d", "M21.796 9.982C20.849 5.357 16.729 2 12 2 6.486 2 2 6.486 2 12c0 4.729 3.357 8.849 7.982 9.796a.988.988 0 0 0 .908-.272l10.633-10.633c.238-.238.34-.578.273-.909zM11 18a7.93 7.93 0 0 1 1.365-4.471 8.18 8.18 0 0 1 .978-1.186 8.211 8.211 0 0 1 1.184-.977 8.128 8.128 0 0 1 1.36-.738c.481-.203.986-.36 1.501-.466a8.112 8.112 0 0 1 2.17-.134l-8.529 8.529c-.013-.185-.029-.37-.029-.557zm-7-6c0-4.411 3.589-8 8-8 2.909 0 5.528 1.589 6.929 4.005a9.99 9.99 0 0 0-1.943.198c-.643.132-1.274.328-1.879.583a10.15 10.15 0 0 0-1.699.923c-.533.361-1.03.771-1.479 1.22s-.858.945-1.221 1.48c-.359.533-.67 1.104-.922 1.698A10.013 10.013 0 0 0 9 18c0 .491.048.979.119 1.461C6.089 18.288 4 15.336 4 12z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
