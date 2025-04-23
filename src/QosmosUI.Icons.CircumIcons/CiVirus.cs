// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiVirus : ComponentBase
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
		builder.AddAttribute(14, "id", "Virus");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M5.86,19.905a.485.485,0,0,0,.35.15.469.469,0,0,0,.35-.15.483.483,0,0,0,0-.7l-.53-.53,1.74-1.74a6.426,6.426,0,0,0,3.73,1.54v2.46h-.75a.5.5,0,0,0,0,1h2.5a.5.5,0,1,0,0-1H12.5v-2.46a6.426,6.426,0,0,0,3.73-1.54l1.74,1.74-.53.53a.483.483,0,0,0,0,.7.469.469,0,0,0,.35.15.485.485,0,0,0,.35-.15l1.77-1.76a.513.513,0,0,0,0-.71.5.5,0,0,0-.71,0l-.52.53-1.74-1.74a6.435,6.435,0,0,0,1.54-3.73h2.46v.75a.5.5,0,0,0,.5.5.5.5,0,0,0,.5-.5v-2.5a.508.508,0,0,0-.5-.5.5.5,0,0,0-.5.5v.75H18.48a6.418,6.418,0,0,0-1.55-3.72l1.75-1.74.52.53a.508.508,0,0,0,.36.15.5.5,0,0,0,.35-.15.513.513,0,0,0,0-.71l-1.77-1.77a.5.5,0,0,0-.7,0,.5.5,0,0,0,0,.71l.53.53-1.74,1.74a6.382,6.382,0,0,0-3.73-1.55V3.065h.75a.5.5,0,0,0,.5-.5.5.5,0,0,0-.5-.5h-2.5a.5.5,0,0,0-.5.5.5.5,0,0,0,.5.5h.75v2.45a6.382,6.382,0,0,0-3.73,1.55L6.03,5.325l.53-.53a.5.5,0,0,0,0-.71.5.5,0,0,0-.7,0L4.09,5.855a.513.513,0,0,0,0,.71.5.5,0,0,0,.35.15.508.508,0,0,0,.36-.15l.52-.53,1.75,1.74A6.418,6.418,0,0,0,5.52,11.5H3.06v-.75a.5.5,0,0,0-.5-.5.508.508,0,0,0-.5.5v2.5a.5.5,0,0,0,.5.5.5.5,0,0,0,.5-.5V12.5H5.52a6.435,6.435,0,0,0,1.54,3.73l-1.74,1.74-.52-.53a.5.5,0,0,0-.71,0,.513.513,0,0,0,0,.71Zm10.03-4.02A5.5,5.5,0,1,1,17.5,12,5.448,5.448,0,0,1,15.89,15.885Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
