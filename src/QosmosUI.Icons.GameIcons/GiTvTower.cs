// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiTvTower : ComponentBase
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
		builder.AddAttribute(14, "d", "M215.027 25l-11.5 46h104.946l-11.5-46h-81.946zM201 89v41.535c4.545-2 9.214-3.766 14-5.27V89h-14zm32 0v31.94c4.594-.78 9.264-1.329 14-1.637V89h-14zm32 0v30.303c4.736.308 9.406.857 14 1.636V89h-14zm32 0v36.266a135.976 135.976 0 0 1 14 5.27V89h-14zm-41 48c-65.828 0-119 53.172-119 119 0 2.35.075 4.683.209 7h237.582c.134-2.317.209-4.65.209-7 0-65.828-53.172-119-119-119zM139.627 281a118.257 118.257 0 0 0 3.893 14h224.96a118.257 118.257 0 0 0 3.893-14H139.627zm11.844 32c20.164 36.971 59.366 62 104.529 62s84.365-25.029 104.53-62H151.47zm47.738 67.668L196.187 429h119.625l-3.021-48.332C295.481 388.583 276.249 393 256 393c-20.249 0-39.48-4.417-56.791-12.332zM195.062 447l-.875 14h123.625l-.875-14H195.063zm-2 32L192 496h128l-1.063-17H193.063z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
