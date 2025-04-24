// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiLumen : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.649 0a.75.75 0 00-.342.072l-4.878 2.23a.75.751 0 10.624 1.366l4.878-2.23A.75.75 0 0011.649 0zm5.624.354a.75.75 0 00-.341.074L6.425 5.306a.75.75 0 00.632 1.362L17.563 1.79a.75.75 0 00-.29-1.436zm0 3.002a.75.75 0 00-.341.074L6.425 8.31a.75.75 0 00.632 1.362l10.506-4.88a.75.75 0 00-.29-1.436zm0 3.002a.75.75 0 00-.341.074L6.425 11.311a.75.75 0 00.632 1.361l10.506-4.878a.75.75 0 00-.29-1.436zm.009 3.003a.75.75 0 00-.342.07l-3.753 1.688a.75.75 0 00-.442.685v3.518a.75.75 0 00.001.047h-1.503a.75.75 0 000-.047v-2.58a.75.75 0 00-.761-.761.75.75 0 00-.74.761v2.58a.75.75 0 00.002.047h-.94a.461.461 0 00-.47.555l.19 1.14a.687.687 0 00.656.557h2.28l-2.537.476a.375.375 0 10.139.737l6.003-1.126a.375.375 0 00.307-.41.625.625 0 00.092-.232l.19-1.142a.461.461 0 00-.47-.555h-.94a.75.75 0 00.002-.047V12.29l3.31-1.49a.75.75 0 00-.274-1.438zm-2.292 9.385a.375.375 0 00-.063.007l-6.004 1.126a.375.375 0 10.139.737l6.003-1.125a.375.375 0 00-.075-.745zm0 1.876a.375.375 0 00-.063.008l-6.004 1.125a.375.375 0 10.139.737l6.003-1.125a.375.375 0 00-.075-.745zm-.743 1.876a.375.375 0 00-.064.006l-4.471.751a.375.375 0 10.124.74l4.472-.75a.375.375 0 00-.061-.747z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
