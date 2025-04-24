// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiSonarlint : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0C5.412 0 0 5.342 0 12c0 6.66 5.411 12 12 12 6.59 0 12-5.41 12-12 0-6.658-5.41-12-12-12zm0 2.22A9.77 9.77 0 0 1 21.78 12 9.768 9.768 0 0 1 12 21.78 9.77 9.77 0 0 1 2.22 12 9.771 9.771 0 0 1 12 2.22zM5.203 9.988c-.763 0-1.179.763-1.456 1.387 0 0-.208.555-.347.763-.07.277-.486 1.18-.14 1.665.209.277.486-.139.694-.347.139-.208.418-.833.418-.833.346-.555.485-.832.831-.832.347 0 .555.278.832.902.347.625.695 1.388 1.458 1.388s1.179-.763 1.456-1.388c.278-.555.485-.902.832-.902s.556.278.833.902c.347.625.694 1.388 1.457 1.388.763 0 1.179-.763 1.456-1.388.278-.555.485-.902.832-.902s.556.278.833.902c.347.625.694 1.388 1.457 1.388.763 0 1.179-.763 1.456-1.388.277-.555.486-.902.833-.902s.555.278.832.902c0 0 .139.277.347.624.07.138.416.693.693.693.278 0 .347-.832.07-1.525-.278-.625-.485-1.11-.485-1.11-.347-.624-.694-1.387-1.457-1.387-.763 0-1.18.763-1.458 1.387-.277.555-.485.901-.831.901-.347 0-.555-.277-.832-.9-.347-.625-.695-1.388-1.458-1.388s-1.179.763-1.456 1.387c-.278.555-.485.901-.832.901s-.556-.277-.833-.9c-.347-.625-.694-1.388-1.457-1.388-.763 0-1.179.763-1.456 1.387-.278.555-.485.901-.832.901s-.556-.277-.833-.9c-.347-.625-.694-1.388-1.457-1.388z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
