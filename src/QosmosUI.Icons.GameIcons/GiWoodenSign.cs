// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiWoodenSign : ComponentBase
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
		builder.AddAttribute(14, "d", "M240.03 35.938c-1.08.01-2.168.062-3.25.124-8.644.502-17.16 2.8-22.5 5.97-5.336 3.167-7.018 5.72-6.81 9.593v.25l.78 28.156 59.97-1.28-.876-31.844c-.148-3.014-1.806-5.15-7.47-7.593C255.63 37.48 249.63 36.27 243.25 36c-1.063-.045-2.138-.074-3.22-.063zm224.94 57.218L33.593 102.53l1.375 62 154.655 4.064-148.156 9.72-2.907 98.81 1.406.313 8.06 1.844-.843 8.22-6.906 67.47 429.533-9.283L464.219 283l-140.376-3.656 139.22-9.156-8.877-99.407-138.875-3.624 151.032-9.937-1.375-64.064zM276.31 368.562l-59.875 1.282L220 495.78h59.844l-3.53-127.217z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
