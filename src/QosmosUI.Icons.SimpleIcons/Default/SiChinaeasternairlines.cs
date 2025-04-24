// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiChinaeasternairlines : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.572 2.383c-1.846 0-2.245.238-2.962 1.205-.38.516-3.568 4.915-5.009 6.898-.18.236-.446.486-1.03.486H0v.004c3.05 8.61 6.324 10.64 9.602 10.64h5.178c.07 0 .146-.08-.041-.124-3.805-.953-7.57-3.984-7.589-6.962.066 2.464 5.255 3.315 10.876 4.016.098.011.093-.065.063-.12l-.17-.293c-.02-.039-.043-.068-.124-.088-3.094-.787-6.242-1.938-6.242-3.01 0-2.032 5.272-4.042 11.27-4.96.195-.04.29-.076.42-.18.17-.136.536-.433.695-.554.096-.085.061-.11.025-.11-.16 0-.326.004-.485.01-7.898.219-15.544 2.008-16.253 4.55-.002.014-.01.027-.014.04.937-4.652 7.198-9.162 15.008-11.28.18-.052.239-.168.014-.168Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
