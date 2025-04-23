// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaStroopwafelSolid : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 16 3 C 8.832 3 3 8.832 3 16 C 3 23.168 8.832 29 16 29 C 23.168 29 29 23.168 29 16 C 29 8.832 23.168 3 16 3 z M 16 5 C 16.501153 5 16.991034 5.0460846 17.474609 5.1113281 L 16 6.5859375 L 14.525391 5.1113281 C 15.008966 5.0460846 15.498847 5 16 5 z M 12.255859 5.6699219 L 14.585938 8 L 12 10.585938 L 8.9667969 7.5527344 C 9.9356929 6.7446104 11.048448 6.1091031 12.255859 5.6699219 z M 19.744141 5.6699219 C 20.951552 6.1091031 22.064307 6.7446104 23.033203 7.5527344 L 20 10.585938 L 17.414062 8 L 19.744141 5.6699219 z M 7.5527344 8.9667969 L 10.585938 12 L 8 14.585938 L 5.6699219 12.255859 C 6.1091031 11.048448 6.7446104 9.9356929 7.5527344 8.9667969 z M 24.447266 8.9667969 C 25.25539 9.9356929 25.890897 11.048448 26.330078 12.255859 L 24 14.585938 L 21.414062 12 L 24.447266 8.9667969 z M 16 9.4140625 L 18.585938 12 L 16 14.585938 L 13.414062 12 L 16 9.4140625 z M 12 13.414062 L 14.585938 16 L 12 18.585938 L 9.4140625 16 L 12 13.414062 z M 20 13.414062 L 22.585938 16 L 20 18.585938 L 17.414062 16 L 20 13.414062 z M 5.1113281 14.525391 L 6.5859375 16 L 5.1113281 17.474609 C 5.0460846 16.991034 5 16.501153 5 16 C 5 15.498847 5.0460846 15.008966 5.1113281 14.525391 z M 26.888672 14.525391 C 26.953915 15.008966 27 15.498847 27 16 C 27 16.501153 26.953915 16.991034 26.888672 17.474609 L 25.414062 16 L 26.888672 14.525391 z M 8 17.414062 L 10.585938 20 L 7.5527344 23.033203 C 6.7446104 22.064307 6.1091031 20.951552 5.6699219 19.744141 L 8 17.414062 z M 16 17.414062 L 18.585938 20 L 16 22.585938 L 13.414062 20 L 16 17.414062 z M 24 17.414062 L 26.330078 19.744141 C 25.890897 20.951552 25.25539 22.064307 24.447266 23.033203 L 21.414062 20 L 24 17.414062 z M 12 21.414062 L 14.585938 24 L 12.255859 26.330078 C 11.048448 25.890897 9.9356929 25.25539 8.9667969 24.447266 L 12 21.414062 z M 20 21.414062 L 23.033203 24.447266 C 22.064307 25.25539 20.951552 25.890897 19.744141 26.330078 L 17.414062 24 L 20 21.414062 z M 16 25.414062 L 17.474609 26.888672 C 16.991034 26.953915 16.501153 27 16 27 C 15.498847 27 15.008966 26.953915 14.525391 26.888672 L 16 25.414062 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
