// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiAntibody : ComponentBase
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
		builder.AddAttribute(14, "d", "M95.812 29.781a18.002 18.002 0 0 0-12.54 30.91l81.636 81.637-14.543 14.543-73.637-73.637a18.002 18.002 0 0 0-12.916-5.453 18.002 18.002 0 0 0-12.54 30.91l96 96a18.002 18.002 0 1 0 25.456-25.457l-9.636-9.637 14.543-14.543L206 183.418v280.545a18.002 18.002 0 1 0 36 0v-199h28v199a18.002 18.002 0 1 0 36 0V183.418l28.365-28.364 14.543 14.543-9.637 9.637a18.002 18.002 0 1 0 25.457 25.457l96-96a18.002 18.002 0 0 0-13.082-30.902 18.002 18.002 0 0 0-12.375 5.445l-73.636 73.637-14.543-14.543 81.636-81.637a18.002 18.002 0 0 0-13.082-30.902 18.002 18.002 0 0 0-12.375 5.445L270 168.508v78.455h-28v-78.455L108.728 35.234a18.002 18.002 0 0 0-12.916-5.453z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
