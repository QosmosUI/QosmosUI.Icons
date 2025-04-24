// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiWaves : ComponentBase
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
		builder.AddAttribute(14, "d", "M15 19c-1.342 0-2.685-.511-3.707-1.532-1.266-1.265-3.323-1.264-4.586 0-.391.391-1.023.391-1.414 0s-.391-1.023 0-1.414c2.043-2.043 5.369-2.043 7.414 0 1.265 1.264 3.322 1.263 4.586 0 .391-.391 1.023-.391 1.414 0s.391 1.023 0 1.414c-1.021 1.021-2.364 1.532-3.707 1.532zM15 15c-1.342 0-2.685-.511-3.707-1.532-1.266-1.265-3.323-1.264-4.586 0-.391.391-1.023.391-1.414 0s-.391-1.023 0-1.414c2.043-2.043 5.369-2.043 7.414 0 1.265 1.264 3.322 1.263 4.586 0 .391-.391 1.023-.391 1.414 0s.391 1.023 0 1.414c-1.021 1.021-2.364 1.532-3.707 1.532zM15 11c-1.342 0-2.685-.511-3.707-1.532-1.266-1.265-3.323-1.264-4.586 0-.391.391-1.023.391-1.414 0s-.391-1.023 0-1.414c2.043-2.042 5.369-2.044 7.414 0 1.265 1.264 3.322 1.263 4.586 0 .391-.391 1.023-.391 1.414 0s.391 1.023 0 1.414c-1.021 1.021-2.364 1.532-3.707 1.532z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
