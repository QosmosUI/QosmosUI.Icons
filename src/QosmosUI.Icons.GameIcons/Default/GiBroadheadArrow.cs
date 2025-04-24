// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBroadheadArrow : ComponentBase
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
		builder.AddAttribute(14, "d", "M19.656 20.688v36.437L73.5 110.97c6.515-14.93 17.988-27.23 32.313-34.814L50.25 20.686l-30.594.002zm119.47 65.906c-29.312 0-52.876 23.533-52.876 52.844 0 21.654 12.868 40.178 31.406 48.375 1.88-37.477 32.825-67.482 70.656-67.907-7.734-19.565-26.786-33.312-49.187-33.312zm213.843 44.25L312.06 145.47l97.032 253.436 7.5 19.625L397 410.97l-253.28-97.533-14.345 40.97L492.28 494.312l-139.31-363.47zm-163.845 7.72c-29.31 0-52.875 23.563-52.875 52.874 0 24.35 16.282 44.705 38.594 50.906 2.935-34.576 30.61-62.252 65.187-65.188-6.2-22.312-26.553-38.594-50.905-38.594zm113.5 34.53L278.75 273.688l-1.344 5.625-5.625 1.312-100.124 23.53L384.156 386l-81.53-212.906zm-56.5 22.47c-29.31 0-52.875 23.563-52.875 52.874 0 10.896 3.28 20.983 8.875 29.375l59.78-14.063 14.033-59.03c-8.473-5.784-18.724-9.157-29.813-9.157z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
