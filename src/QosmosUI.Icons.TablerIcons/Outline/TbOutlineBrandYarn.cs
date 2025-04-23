// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Outline;

public class TbOutlineBrandYarn : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M17.845 19.308c-1.268 .814 -2.41 1.254 -3.845 1.692c-.176 .21 -.645 .544 -.912 .588a42.469 42.469 0 0 1 -4.498 .412c-.812 .006 -1.31 -.214 -1.447 -.554c-.115 -.279 .336 -2.054 .298 -1.964c-.157 .392 -.575 1.287 -.997 1.72c-.579 .6 -1.674 .4 -2.322 .051c-.71 -.386 -.07 -1.28 -.346 -1.267c-.276 .014 -.776 -1.486 -.776 -2.236c0 -.828 .622 -1.674 1.235 -2.211a6.811 6.811 0 0 1 .46 -3.143a7.414 7.414 0 0 1 2.208 -2.615s-1.353 -1.534 -.849 -2.912c.328 -.902 .46 -.895 .567 -.935c.38 -.12 .727 -.33 1.013 -.612c.78 -.88 1.96 -1.438 3.116 -1.322c0 0 .781 -2.43 1.533 -1.936c.415 .653 .671 1.218 .967 1.936c0 0 1.15 -.7 1.25 -.5c.514 1.398 .487 3.204 .211 4.67c-.324 1.408 -.84 2.691 -1.711 3.83c-.094 .16 .98 .705 1.722 2.812c.686 1.928 .278 2.438 .278 2.688s.716 .144 2.296 -.855a5.848 5.848 0 0 1 2.984 -1.145c.735 -.066 .988 -.035 1.22 1c.232 1.035 -.346 1.406 -.744 1.506c0 0 -2.09 .675 -2.911 1.302z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
