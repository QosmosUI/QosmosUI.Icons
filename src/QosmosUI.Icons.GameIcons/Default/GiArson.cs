// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiArson : ComponentBase
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
		builder.AddAttribute(14, "d", "M292.188 16.22c-111.482 14.198-135.342 99.816-95.063 166.28-43.158-17.874-61.805-44.185-43.656-82.47-41.67 21.616-63.65 64.594-62.72 111 .727 36.28 15.237 64.622 37.72 85.157-11.34-28.98-14.304-59.254-7.064-84.78 35.742 49.33 137.816-19.996 147.125-79.282-.036 63.674 63.968 118.383 112.69 52.406 8.686 35.966 6.747 73.19-2.44 103.157 18.762-19.76 30.682-45.355 31.564-76.656 1.263-44.876-21.042-74.46-72.125-96.06 19.285 27.88 11.738 60.293-8.814 73.843 13.512-68.19-120.605-105.09-37.22-172.532l.002-.06zm21.375 217.093v41.593l-.72-.562H199.72l-97.314 74.437h51.28v141.876H297.72v-68.28h37v68.28H358V348.78h52.156L358 308.876v-75.563h-44.438zM176.72 360.156h37v35.594h-37v-35.594zm59.78 0h37.03v35.594H236.5v-35.594zm60.5 0h37.03v35.594H297v-35.594zm-120.28 61.53l37 .002v35.562h-37v-35.563zm59.78.002h37.03v35.562H236.5v-35.563z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
