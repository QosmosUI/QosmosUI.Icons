// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons;

public class DiCodrops : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "32";

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
		builder.AddAttribute(14, "d", "M13.788 5.14c-3.644 0.777-6.878 3.432-8.234 6.765-1.144 2.796-1.144 5.988 0 8.785 1.2 2.938 3.884 5.395 7.033 6.44 1.13 0.367 1.398 0.395 3.418 0.395s2.288-0.028 3.418-0.395c4.76-1.568 7.881-5.847 7.881-10.832 0-4.943-3.023-9.152-7.739-10.776-1.088-0.367-1.441-0.424-3.206-0.466-1.088-0.028-2.246 0.014-2.57 0.085zM17.276 12.54c1.949 3.418 2.556 5.098 2.288 6.299-0.424 1.808-2.006 2.966-3.813 2.782-0.89-0.099-1.85-0.636-2.387-1.313l-0.339-0.452h0.565c1.539-0.028 2.726-1.483 2.486-3.065-0.085-0.65-0.565-1.935-1.13-3.037l-0.325-0.636 0.72-1.229c0.395-0.678 0.763-1.2 0.819-1.158 0.057 0.028 0.565 0.847 1.116 1.808zM14.31 13.896c1.215 2.415 1.426 3.474 0.904 4.378-0.946 1.596-3.192 1.144-3.658-0.748-0.071-0.226-0.014-0.678 0.141-1.13 0.254-0.805 1.765-3.63 1.935-3.63 0.057 0 0.367 0.508 0.678 1.13z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
