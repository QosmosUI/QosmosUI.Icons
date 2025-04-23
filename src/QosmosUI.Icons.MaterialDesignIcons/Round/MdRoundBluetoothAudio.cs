// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundBluetoothAudio : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M15.98 10.28l-1.38 1.38c-.2.2-.2.51 0 .71l1.38 1.38c.28.28.75.15.85-.23.11-.5.17-1 .17-1.52 0-.51-.06-1.01-.18-1.48-.09-.38-.56-.52-.84-.24zm4.12-2.5c-.25-.55-.98-.67-1.4-.24-.26.26-.31.64-.17.98.46 1.07.72 2.24.72 3.47 0 1.24-.26 2.42-.73 3.49-.14.32-.09.69.16.94.41.41 1.1.29 1.35-.23.63-1.3.98-2.76.98-4.3-.01-1.45-.33-2.85-.91-4.11zM11.39 12l3.59-3.58c.39-.39.39-1.02 0-1.42l-4.29-4.29c-.63-.63-1.71-.18-1.71.71V9.6L5.09 5.7c-.39-.39-1.02-.39-1.41 0-.39.39-.39 1.02 0 1.41L8.57 12l-4.89 4.89c-.39.39-.39 1.02 0 1.41.39.39 1.02.39 1.41 0l3.89-3.89v6.18c0 .89 1.08 1.34 1.71.71l4.3-4.3c.39-.39.39-1.02 0-1.42L11.39 12zm-.41-6.17l1.88 1.88-1.88 1.88V5.83zm0 12.34v-3.76l1.88 1.88-1.88 1.88z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
