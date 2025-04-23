// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoBellSlash : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M1.22 1.22a.75.75 0 0 1 1.06 0l20.5 20.5a.749.749 0 0 1-.326 1.275.749.749 0 0 1-.734-.215L17.94 19H15.5a3.5 3.5 0 1 1-7 0H3.518a1.516 1.516 0 0 1-1.263-2.36l2.2-3.298A3.249 3.249 0 0 0 5 11.539V7c0-.294.025-.583.073-.866L1.22 2.28a.75.75 0 0 1 0-1.06ZM6.5 7.56h-.001v3.979a4.75 4.75 0 0 1-.797 2.635l-2.2 3.298-.003.01.001.007.004.006.006.004.007.001H16.44ZM10 19a2 2 0 1 0 4 0Zm2-16.5c-1.463 0-2.8.485-3.788 1.257l-.04.032a.75.75 0 1 1-.935-1.173l.05-.04C8.548 1.59 10.212 1 12 1c3.681 0 7 2.565 7 6v4.539c0 .642.19 1.269.546 1.803l1.328 1.992a.75.75 0 1 1-1.248.832l-1.328-1.992a4.75 4.75 0 0 1-.798-2.635V7c0-2.364-2.383-4.5-5.5-4.5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
