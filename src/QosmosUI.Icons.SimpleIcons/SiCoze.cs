// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiCoze : ComponentBase
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
		builder.AddAttribute(15, "d", "M9.366 12.096a.61.61 0 0 0-.608.608v1.218a.609.609 0 1 0 1.217 0v-1.218a.61.61 0 0 0-.609-.608m.8 3.453a.605.605 0 0 1 0-.86.605.605 0 0 1 .859 0 1.52 1.52 0 0 0 2.149 0 .605.605 0 0 1 .859 0 .605.605 0 0 1 0 .86 2.73 2.73 0 0 1-3.867 0m4.062-2.24a.61.61 0 1 1 .609.609.606.606 0 0 1-.61-.609zM3.023 0A3.024 3.024 0 0 0 0 3.023v17.954A3.024 3.024 0 0 0 3.023 24h17.954A3.024 3.024 0 0 0 24 20.977V3.023A3.024 3.024 0 0 0 20.977 0ZM12.1 3.78h.004a6.287 6.287 0 0 1 6.283 6.286v2.635h1.508c1.73 0 2.12 2.426.476 2.97l-1.984.663v1.137a1.513 1.513 0 0 1-2.19 1.353l-1.101-.549c-.052-.024-.115 0-.131.055-.892 2.785-4.835 2.785-5.727 0a.095.095 0 0 0-.13-.055l-1.102.55a1.513 1.513 0 0 1-2.19-1.354v-1.139l-1.984-.66c-1.647-.541-1.254-2.97.477-2.97h1.507v-2.636A6.285 6.285 0 0 1 12.1 3.78");
		builder.CloseElement();
		builder.CloseElement();
    }
}
