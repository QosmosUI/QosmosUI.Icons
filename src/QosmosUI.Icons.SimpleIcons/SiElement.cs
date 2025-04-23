// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiElement : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0C5.373 0 0 5.373 0 12s5.373 12 12 12 12-5.373 12-12S18.627 0 12 0zm-1.314 4.715c3.289 0 5.956 2.66 5.956 5.943 0 .484-.394.877-.879.877s-.879-.393-.879-.877c0-2.313-1.88-4.189-4.198-4.189-.486 0-.879-.393-.879-.877s.392-.877.879-.877zm-5.092 9.504c-.486 0-.879-.394-.879-.877 0-3.283 2.666-5.945 5.956-5.945.485 0 .879.393.879.877s-.394.876-.879.876c-2.319 0-4.198 1.877-4.198 4.191 0 .484-.395.878-.879.878zm7.735 5.067c-3.29 0-5.957-2.662-5.957-5.944 0-.484.394-.878.879-.878s.879.394.879.878c0 2.313 1.88 4.189 4.199 4.189.485 0 .879.393.879.877 0 .486-.394.878-.879.878zm0-2.683c-.485 0-.88-.393-.88-.876 0-.484.395-.878.88-.878 2.318 0 4.199-1.876 4.199-4.19 0-.484.393-.877.879-.877.485 0 .879.393.879.877 0 3.282-2.667 5.944-5.957 5.944z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
