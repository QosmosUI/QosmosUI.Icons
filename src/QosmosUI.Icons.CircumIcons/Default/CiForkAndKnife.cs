// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiForkAndKnife : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Fork_Knife");
		builder.AddAttribute(15, "data-name", "Fork & Knife");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M18.83,2.25a6.469,6.469,0,0,0-4.37,6.12v3.15a1.784,1.784,0,0,0,1.78,1.78h2.7v8.14a.5.5,0,0,0,.5.5.508.508,0,0,0,.5-.5V2.56a.508.508,0,0,0-.5-.5.467.467,0,0,0-.17.03ZM16.24,12.3a.781.781,0,0,1-.78-.78V8.37a5.482,5.482,0,0,1,3.48-5.1V12.3Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M11.44,2.07a.5.5,0,0,0-.5.5V7.55H8.5V2.57a.5.5,0,0,0-.5-.5.5.5,0,0,0-.5.5V7.55H5.06V2.57a.5.5,0,0,0-.5-.5.5.5,0,0,0-.5.5V9.05a2.507,2.507,0,0,0,2.5,2.5H7.5v9.89a.508.508,0,0,0,.5.5.5.5,0,0,0,.5-.5V11.55h.94a2.5,2.5,0,0,0,2.5-2.5V2.57A.5.5,0,0,0,11.44,2.07Zm-.5,6.98a1.5,1.5,0,0,1-1.5,1.5H6.56a1.511,1.511,0,0,1-1.5-1.5v-.5h5.88Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
