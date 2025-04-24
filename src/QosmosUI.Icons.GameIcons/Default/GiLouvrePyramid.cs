// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiLouvrePyramid : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 71.3L14.72 416H497.3zm0 31.4l21 30-21 30-21-30zm-32 45.7l21 30-21 30-21-30zm64 0l21 30-21 30-21-30zm-86.7 32.4l-9.3 13.4 21 30-21 29.9-21-30zM320 194.1l21 30-21 30-21-30zm-64 .1l21 29.9-21 30-21-30zm-88.6 35l-7.4 10.7 21 30-21 29.9-21-30zM352 239.8l21 30-21 30-21-30zm-128 .1l21 30-21 29.9-21-29.9zm64 0l21 30-21 29.9-21-29.9zm-154.3 37.6l-5.7 8.1 21 30-21 29.9-21-30zm245.9 1.8l25.4 36.2-21 30-21-29.9 21-30zM192 285.6l21 30-21 29.9-21-29.9zm64 0l21 30-21 29.9-21-29.9zm64 0l21 30-21 29.9-21-29.9zM98.51 327.7l-2.52 3.6 21.01 30L91.29 398h-42zm315.19.4l49 69.9h-42L395 361.3l21-30zM160 331.3l21 30-21 29.9-21-29.9zm64 0l21 30-21 29.9-21-29.9zm64 0l21 30-21 29.9-21-29.9zm64 0l21 30-21 29.9-21-29.9zm-224 45.8l14.6 20.9h-29.2zm64 0l14.6 20.9h-29.2zm64 0l14.6 20.9h-29.2zm64 0l14.6 20.9h-29.2zm64 0l14.6 20.9h-29.2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
