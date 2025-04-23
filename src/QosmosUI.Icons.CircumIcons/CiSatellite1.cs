// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiSatellite1 : ComponentBase
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
		builder.AddAttribute(14, "id", "Satellite_1");
		builder.AddAttribute(15, "data-name", "Satellite 1");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M17.135,12.37a5.447,5.447,0,0,0,3.42-1.2.982.982,0,0,0,.37-.72,1.04,1.04,0,0,0-.31-.8l-2.78-2.78c.39-.39.8-.8,1.19-1.2.08-.07.15-.14.23-.22a.511.511,0,0,0,0-.7.5.5,0,0,0-.71,0c-.48.47-.94.94-1.42,1.41l-2.78-2.78a1.077,1.077,0,0,0-.8-.31,1,1,0,0,0-.72.37,5.454,5.454,0,0,0-1.19,3.67l-1.45,1.46L7.855,6.24a.978.978,0,0,0-1.41,0L3.365,9.32a1,1,0,0,0,0,1.41L5.7,13.06l-.41.4a2.65,2.65,0,0,0,0,3.74L6.8,18.71a2.632,2.632,0,0,0,3.74,0l.4-.4,2.33,2.33a1,1,0,0,0,1.41,0l3.08-3.09a1,1,0,0,0,0-1.41l-2.32-2.32,1.45-1.46A2.09,2.09,0,0,0,17.135,12.37ZM4.065,10.03l3.09-3.09,2.32,2.33L6.4,12.35Zm12.99,6.82-3.08,3.08-2.33-2.33,3.08-3.08Zm-5.23-8.51a5.482,5.482,0,0,0,3.84,3.83l-5.84,5.84a1.642,1.642,0,0,1-2.32,0l-1.52-1.52a1.642,1.642,0,0,1,0-2.32Zm2.12,1.71a4.417,4.417,0,0,1-.3-5.96l3.13,3.13,3.14,3.14.02.03A4.5,4.5,0,0,1,13.945,10.05Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
