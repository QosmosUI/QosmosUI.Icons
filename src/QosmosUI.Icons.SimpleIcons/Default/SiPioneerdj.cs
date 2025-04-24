// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiPioneerdj : ComponentBase
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
		builder.AddAttribute(15, "d", "M15.46 5.569c1.474 1.144 1.715 2.695 1.107 4.319-.565 1.503-1.833 2.96-3.827 4.087-2.21 1.227-4.498 1.554-6.993 1.554H0L4.212 4.308h5.051c2.548 0 4.7.1 6.197 1.26zm-3.112 4.235c.33-.884.246-2.202-.34-2.906-.658-.782-1.673-.873-3.138-.873l-.716.016s-.616-.07-.866.49c-.153.35.064-.263-2.412 6.341-.326.876.452.919.452.919s2.794.17 5.132-1.448c.991-.685 1.577-1.705 1.888-2.539zm5.938-1.467L24 8.366l-2.892 7.731c-.944 2.518-2.896 3.595-6.812 3.595l-3.058-.04.731-1.746c4.427.21 5.225-1.76 5.365-2.139l1.846-4.966s.317-.884-.402-.884h-1.132Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
