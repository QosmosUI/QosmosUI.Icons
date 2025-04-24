// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiUmbrella : ComponentBase
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
		builder.AddAttribute(14, "id", "Umbrella");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M12.5,4.06v-.5a.509.509,0,0,0-.15-.35.483.483,0,0,0-.7,0,.491.491,0,0,0-.15.35v.5a8.41,8.41,0,0,0-7.88,7.82.976.976,0,0,0,.27.74,1.029,1.029,0,0,0,.74.32H11.5v5.22a1.653,1.653,0,0,1-.62,1.54A1.528,1.528,0,0,1,8.5,18.54a.5.5,0,0,0-1,0,2.433,2.433,0,0,0,2.43,2.4,2.45,2.45,0,0,0,2.57-2.29c.08-1.39,0-2.81,0-4.2V12.94h6.87a1.029,1.029,0,0,0,.74-.32.976.976,0,0,0,.27-.74A8.41,8.41,0,0,0,12.5,4.06Zm6.87,7.88-14.75.01a7.4,7.4,0,0,1,14.76-.02C19.38,11.94,19.38,11.94,19.37,11.94Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
