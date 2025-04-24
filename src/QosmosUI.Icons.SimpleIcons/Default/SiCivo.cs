// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiCivo : ComponentBase
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
		builder.AddAttribute(15, "d", "M9.229 7.985h-.993c-.183 0-.303.14-.303.318v7.393c0 .177.12.318.303.318h.993a.318.318 0 0 0 .323-.318V8.303a.317.317 0 0 0-.323-.318m-3.1 5.838a.32.32 0 0 0-.507-.104 2.34 2.34 0 0 1-1.604.635c-1.627 0-2.868-1.65-2.141-3.368a2.128 2.128 0 0 1 1.13-1.128c.992-.42 1.958-.18 2.599.408a.32.32 0 0 0 .507-.103l.43-.943a.353.353 0 0 0-.111-.428C5.425 8.03 4.05 7.732 2.617 8.22a3.838 3.838 0 0 0-2.412 2.478c-.874 2.772 1.172 5.32 3.813 5.32.92 0 1.764-.31 2.44-.831a.348.348 0 0 0 .101-.42zm17.666-3.125a3.838 3.838 0 0 0-2.412-2.478 4.176 4.176 0 0 0-2.329-.13c-1.2.269-2.07.838-2.834 2.479l-1.534 3.326-2.603-5.722a.32.32 0 0 0-.29-.187l-1.138-.002a.32.32 0 0 0-.292.453l3.376 7.382a.324.324 0 0 0 .291.19l.056.005h1.276a.236.236 0 0 0 .076-.013.335.335 0 0 0 .2-.18l1.71-3.893c.515-1.213.827-1.718 1.643-2.065a2.527 2.527 0 0 1 2.054.026c.492.222.878.629 1.084 1.128a2.701 2.701 0 0 1 .206.95 2.354 2.354 0 0 1-2.353 2.387 2.34 2.34 0 0 1-1.604-.635.32.32 0 0 0-.507.104l-.43.944a.348.348 0 0 0 .1.42c.677.52 1.522.831 2.44.831 2.642 0 4.688-2.548 3.814-5.32");
		builder.CloseElement();
		builder.CloseElement();
    }
}
